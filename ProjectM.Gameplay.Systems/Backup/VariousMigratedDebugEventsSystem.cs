// Decompiled with JetBrains decompiler
// Type: ProjectM.VariousMigratedDebugEventsSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Physics;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class VariousMigratedDebugEventsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SetTimeOfDayEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChangeDurabilityEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChangeHealthOfClosestToPositionEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CompleteCurrentAchievementEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ALL_FILTER;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob2_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob2_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob3_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob3_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob4_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob4_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob5_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob5_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleChangeDurabilityEvent_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleChangeDurabilityEvent_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryFindUserWithCharacterName_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TryFindUserWithCharacterName_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleSetTimeOfDayEvent_Private_Void_SetTimeOfDayEvent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleChangeDurabilityEvent_Private_Void_byref_ChangeDurabilityDebugEvent_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleChangeHealthOfClosestToPositionEvent_Private_Void_byref_ChangeHealthOfClosestToPositionDebugEvent_byref_FromCharacter_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HandleCompleteCurrentAchievementEvent_Private_Void_byref_CompleteCurrentAchievementAdminEvent_byref_FromCharacter_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryFindUserWithCharacterName_Private_Boolean_FixedString64_byref_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleChangeDurabilityEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTryFindUserWithCharacterName_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_3;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_4;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_6;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426372, XrefRangeEnd = 1426408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426408, XrefRangeEnd = 1426496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1426580, RefRangeEnd = 1426581, XrefRangeStart = 1426496, XrefRangeEnd = 1426580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleSetTimeOfDayEvent(SetTimeOfDayEvent evt)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &evt;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_HandleSetTimeOfDayEvent_Private_Void_SetTimeOfDayEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1426595, RefRangeEnd = 1426596, XrefRangeStart = 1426581, XrefRangeEnd = 1426595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleChangeDurabilityEvent(
      [In] ref ChangeDurabilityDebugEvent evt,
      FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref evt;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_HandleChangeDurabilityEvent_Private_Void_byref_ChangeDurabilityDebugEvent_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1426633, RefRangeEnd = 1426634, XrefRangeStart = 1426596, XrefRangeEnd = 1426633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleChangeHealthOfClosestToPositionEvent(
      [In] ref ChangeHealthOfClosestToPositionDebugEvent clientEvent,
      [In] ref FromCharacter fromCharacter,
      double serverTime)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) ref clientEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_HandleChangeHealthOfClosestToPositionEvent_Private_Void_byref_ChangeHealthOfClosestToPositionDebugEvent_byref_FromCharacter_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1426726, RefRangeEnd = 1426727, XrefRangeStart = 1426634, XrefRangeEnd = 1426726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void HandleCompleteCurrentAchievementEvent(
      [In] ref CompleteCurrentAchievementAdminEvent clientEvent,
      [In] ref FromCharacter fromCharacter)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref clientEvent;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_HandleCompleteCurrentAchievementEvent_Private_Void_byref_CompleteCurrentAchievementAdminEvent_byref_FromCharacter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1426744, RefRangeEnd = 1426745, XrefRangeStart = 1426727, XrefRangeEnd = 1426744, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryFindUserWithCharacterName(FixedString64 characterName, out Entity result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &characterName;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_TryFindUserWithCharacterName_Private_Boolean_FixedString64_byref_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VariousMigratedDebugEventsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426745, XrefRangeEnd = 1427000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427000, XrefRangeEnd = 1427016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427016, XrefRangeEnd = 1427032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427032, XrefRangeEnd = 1427048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob2_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427048, XrefRangeEnd = 1427067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob3_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427067, XrefRangeEnd = 1427083, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob4_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427083, XrefRangeEnd = 1427099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob5_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427099, XrefRangeEnd = 1427118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleChangeDurabilityEvent_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleChangeDurabilityEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1427118, XrefRangeEnd = 1427134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTryFindUserWithCharacterName_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryFindUserWithCharacterName_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1427138, RefRangeEnd = 1427139, XrefRangeStart = 1427134, XrefRangeEnd = 1427138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1427143, RefRangeEnd = 1427144, XrefRangeStart = 1427139, XrefRangeEnd = 1427143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1427148, RefRangeEnd = 1427149, XrefRangeStart = 1427144, XrefRangeEnd = 1427148, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1427153, RefRangeEnd = 1427154, XrefRangeStart = 1427149, XrefRangeEnd = 1427153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_3()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1427158, RefRangeEnd = 1427159, XrefRangeStart = 1427154, XrefRangeEnd = 1427158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_4()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1427163, RefRangeEnd = 1427164, XrefRangeStart = 1427159, XrefRangeEnd = 1427163, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_5()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1427168, RefRangeEnd = 1427169, XrefRangeStart = 1427164, XrefRangeEnd = 1427168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_6()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VariousMigratedDebugEventsSystem()
    {
      Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (VariousMigratedDebugEventsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr);
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__SetTimeOfDayEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, nameof (_SetTimeOfDayEventQuery));
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ChangeDurabilityEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, nameof (_ChangeDurabilityEventQuery));
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ChangeHealthOfClosestToPositionEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, nameof (_ChangeHealthOfClosestToPositionEventQuery));
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__CompleteCurrentAchievementEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, nameof (_CompleteCurrentAchievementEventQuery));
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr_ALL_FILTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, nameof (ALL_FILTER));
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob0_entityQuery");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob0_profilerMarker");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob1_entityQuery");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob1_profilerMarker");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob2_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob2_entityQuery");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob2_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob2_profilerMarker");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob3_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob3_entityQuery");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob3_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob3_profilerMarker");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob4_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob4_entityQuery");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob4_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob4_profilerMarker");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob5_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob5_entityQuery");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob5_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleSetTimeOfDayEvent_LambdaJob5_profilerMarker");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleChangeDurabilityEvent_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleChangeDurabilityEvent_LambdaJob0_entityQuery");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleChangeDurabilityEvent_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>HandleChangeDurabilityEvent_LambdaJob0_profilerMarker");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___TryFindUserWithCharacterName_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>TryFindUserWithCharacterName_LambdaJob0_entityQuery");
      VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___TryFindUserWithCharacterName_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>TryFindUserWithCharacterName_LambdaJob0_profilerMarker");
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670128);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670129);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_HandleSetTimeOfDayEvent_Private_Void_SetTimeOfDayEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670130);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_HandleChangeDurabilityEvent_Private_Void_byref_ChangeDurabilityDebugEvent_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670131);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_HandleChangeHealthOfClosestToPositionEvent_Private_Void_byref_ChangeHealthOfClosestToPositionDebugEvent_byref_FromCharacter_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670132);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_HandleCompleteCurrentAchievementEvent_Private_Void_byref_CompleteCurrentAchievementAdminEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670133);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_TryFindUserWithCharacterName_Private_Boolean_FixedString64_byref_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670134);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670135);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670137);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670138);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670139);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob2_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670140);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob3_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670141);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob4_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670142);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleSetTimeOfDayEvent_LambdaJob5_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670143);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleChangeDurabilityEvent_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670144);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForTryFindUserWithCharacterName_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670145);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670146);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670147);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670148);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670149);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670150);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670151);
      VariousMigratedDebugEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, 100670152);
    }

    public VariousMigratedDebugEventsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _SetTimeOfDayEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__SetTimeOfDayEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__SetTimeOfDayEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _ChangeDurabilityEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ChangeDurabilityEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ChangeDurabilityEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _ChangeHealthOfClosestToPositionEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ChangeHealthOfClosestToPositionEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ChangeHealthOfClosestToPositionEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _CompleteCurrentAchievementEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__CompleteCurrentAchievementEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__CompleteCurrentAchievementEventQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe CollisionFilter ALL_FILTER
    {
      get
      {
        CollisionFilter allFilter;
        IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr_ALL_FILTER, (void*) &allFilter);
        return allFilter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr_ALL_FILTER, (void*) &value);
      }
    }

    public unsafe EntityQuery __HandleSetTimeOfDayEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleSetTimeOfDayEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleSetTimeOfDayEvent_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleSetTimeOfDayEvent_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleSetTimeOfDayEvent_LambdaJob2_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob2_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob2_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleSetTimeOfDayEvent_LambdaJob2_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob2_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob2_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleSetTimeOfDayEvent_LambdaJob3_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob3_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob3_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleSetTimeOfDayEvent_LambdaJob3_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob3_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob3_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleSetTimeOfDayEvent_LambdaJob4_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob4_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob4_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleSetTimeOfDayEvent_LambdaJob4_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob4_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob4_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleSetTimeOfDayEvent_LambdaJob5_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob5_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob5_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleSetTimeOfDayEvent_LambdaJob5_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob5_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleSetTimeOfDayEvent_LambdaJob5_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleChangeDurabilityEvent_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleChangeDurabilityEvent_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleChangeDurabilityEvent_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleChangeDurabilityEvent_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleChangeDurabilityEvent_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___HandleChangeDurabilityEvent_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TryFindUserWithCharacterName_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___TryFindUserWithCharacterName_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___TryFindUserWithCharacterName_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TryFindUserWithCharacterName_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___TryFindUserWithCharacterName_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.NativeFieldInfoPtr___TryFindUserWithCharacterName_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/<>c__DisplayClass8_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass8_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_timePerDay;
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr_evt;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameStartTimeOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_newServerTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__0_Internal_Void_byref_DayNightCycle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__1_Internal_Void_byref_ServerTime_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__2_Internal_Void_byref_DayNightCycle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__3_Internal_Void_byref_Age_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__4_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__5_Internal_Void_byref_ServantCoffinstation_0;
      [FieldOffset(0)]
      public float timePerDay;
      [FieldOffset(4)]
      public float time;
      [FieldOffset(8)]
      public SetTimeOfDayEvent evt;
      [FieldOffset(20)]
      public float gameStartTimeOffset;
      [FieldOffset(24)]
      public double newServerTime;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleSetTimeOfDayEvent_b__0(ref DayNightCycle cycle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cycle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__0_Internal_Void_byref_DayNightCycle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleSetTimeOfDayEvent_b__1(ref ServerTime serverTime)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref serverTime;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__1_Internal_Void_byref_ServerTime_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleSetTimeOfDayEvent_b__2(ref DayNightCycle cycle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cycle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__2_Internal_Void_byref_DayNightCycle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleSetTimeOfDayEvent_b__3(ref Age age)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref age;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__3_Internal_Void_byref_Age_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleSetTimeOfDayEvent_b__4(
        ref DynamicBuffer<ActiveServantMission> activeServantMissions)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeServantMissions;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__4_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleSetTimeOfDayEvent_b__5(ref ServantCoffinstation servantCoffinStation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref servantCoffinStation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__5_Internal_Void_byref_ServantCoffinstation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_timePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (timePerDay));
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (time));
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (evt));
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_gameStartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (gameStartTimeOffset));
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeFieldInfoPtr_newServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, nameof (newServerTime));
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100670153);
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__0_Internal_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100670154);
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__1_Internal_Void_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100670155);
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__2_Internal_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100670156);
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__3_Internal_Void_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100670157);
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__4_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100670158);
        VariousMigratedDebugEventsSystem.__c__DisplayClass8_0.NativeMethodInfoPtr__HandleSetTimeOfDayEvent_b__5_Internal_Void_byref_ServantCoffinstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, 100670159);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass8_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_equipmentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_amount;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__HandleChangeDurabilityEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _HandleChangeDurabilityEvent_b__0(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__HandleChangeDurabilityEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (fromCharacter));
        VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
        VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_equipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (equipmentType));
        VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (amount));
        VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr, 100670160);
        VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__HandleChangeDurabilityEvent_b__0_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr, 100670161);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass9_0>.NativeClassPtr, data));
      }

      public unsafe FromCharacter fromCharacter
      {
        get
        {
          return *(FromCharacter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_fromCharacter));
        }
        [param: In] set
        {
          *(FromCharacter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_fromCharacter)) = value;
        }
      }

      public unsafe VariousMigratedDebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (VariousMigratedDebugEventsSystem) null : new VariousMigratedDebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EquipmentType equipmentType
      {
        get
        {
          return *(EquipmentType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_equipmentType));
        }
        [param: In] set
        {
          *(EquipmentType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_equipmentType)) = value;
        }
      }

      public unsafe float amount
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_amount));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_amount)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/<>c__DisplayClass12_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass12_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_characterName;
      private static readonly System.IntPtr NativeFieldInfoPtr_e;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryFindUserWithCharacterName_b__0_Internal_Void_Entity_byref_User_0;
      [FieldOffset(0)]
      public FixedString64 characterName;
      [FieldOffset(64)]
      public Entity e;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass12_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TryFindUserWithCharacterName_b__0(Entity entity, [In] ref User user)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__TryFindUserWithCharacterName_b__0_Internal_Void_Entity_byref_User_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass12_0()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass12_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass12_0>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_characterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (characterName));
        VariousMigratedDebugEventsSystem.__c__DisplayClass12_0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass12_0>.NativeClassPtr, nameof (e));
        VariousMigratedDebugEventsSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass12_0>.NativeClassPtr, 100670162);
        VariousMigratedDebugEventsSystem.__c__DisplayClass12_0.NativeMethodInfoPtr__TryFindUserWithCharacterName_b__0_Internal_Void_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass12_0>.NativeClassPtr, 100670163);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass12_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_timePerDay;
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr_evt;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameStartTimeOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float timePerDay;
      [FieldOffset(4)]
      public float time;
      [FieldOffset(8)]
      public SetTimeOfDayEvent evt;
      [FieldOffset(20)]
      public float gameStartTimeOffset;
      [FieldOffset(24)]
      public VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425609, XrefRangeEnd = 1425612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref DayNightCycle cycle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cycle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425612, RefRangeEnd = 1425613, XrefRangeStart = 1425612, XrefRangeEnd = 1425612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425613, RefRangeEnd = 1425614, XrefRangeStart = 1425613, XrefRangeEnd = 1425613, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425614, XrefRangeEnd = 1425616, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425621, RefRangeEnd = 1425622, XrefRangeStart = 1425616, XrefRangeEnd = 1425621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425624, RefRangeEnd = 1425625, XrefRangeStart = 1425622, XrefRangeEnd = 1425624, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VariousMigratedDebugEventsSystem componentSystem,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425625, XrefRangeEnd = 1425629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425629, XrefRangeEnd = 1425635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_timePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (timePerDay));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (time));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (evt));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_gameStartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (gameStartTimeOffset));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, 100670164);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, 100670165);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, 100670166);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, 100670167);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, 100670168);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, 100670169);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, 100670170);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, 100670171);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_cycle;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<DayNightCycle> forParameter_cycle;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425529, RefRangeEnd = 1425530, XrefRangeStart = 1425526, XrefRangeEnd = 1425529, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VariousMigratedDebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425533, RefRangeEnd = 1425534, XrefRangeStart = 1425530, XrefRangeEnd = 1425533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_cycle));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100670172);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100670173);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_cycle;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<DayNightCycle>.Runtime runtime_cycle;

          static Runtimes()
          {
            Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_cycle));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_0000105C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000105C$PostfixBurstDelegate");
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670174);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670175);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670176);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670177);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0/ProjectM.RunWithoutJobSystem_0000105C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425534, XrefRangeEnd = 1425548, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425548, XrefRangeEnd = 1425566, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425566, XrefRangeEnd = 1425581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425608, RefRangeEnd = 1425609, XrefRangeStart = 1425581, XrefRangeEnd = 1425608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000105C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670178);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670179);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670180);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670181);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670183);
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
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_evt;
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameStartTimeOffset;
      private static readonly System.IntPtr NativeFieldInfoPtr_timePerDay;
      private static readonly System.IntPtr NativeFieldInfoPtr_newServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServerTime_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public SetTimeOfDayEvent evt;
      [FieldOffset(12)]
      public float time;
      [FieldOffset(16)]
      public float gameStartTimeOffset;
      [FieldOffset(20)]
      public float timePerDay;
      [FieldOffset(24)]
      public double newServerTime;
      [FieldOffset(32)]
      public VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425722, RefRangeEnd = 1425723, XrefRangeStart = 1425718, XrefRangeEnd = 1425722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref ServerTime serverTime)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref serverTime;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServerTime_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425723, RefRangeEnd = 1425724, XrefRangeStart = 1425723, XrefRangeEnd = 1425723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425724, RefRangeEnd = 1425725, XrefRangeStart = 1425724, XrefRangeEnd = 1425724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425725, XrefRangeEnd = 1425727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425732, RefRangeEnd = 1425733, XrefRangeStart = 1425727, XrefRangeEnd = 1425732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425735, RefRangeEnd = 1425736, XrefRangeStart = 1425733, XrefRangeEnd = 1425735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VariousMigratedDebugEventsSystem componentSystem,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425736, XrefRangeEnd = 1425740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425740, XrefRangeEnd = 1425746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (evt));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (time));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_gameStartTimeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (gameStartTimeOffset));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_timePerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (timePerDay));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_newServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (newServerTime));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServerTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, 100670184);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, 100670185);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, 100670186);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, 100670187);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, 100670188);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, 100670189);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, 100670190);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, 100670191);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_serverTime;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<ServerTime> forParameter_serverTime;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425638, RefRangeEnd = 1425639, XrefRangeStart = 1425635, XrefRangeEnd = 1425638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VariousMigratedDebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425642, RefRangeEnd = 1425643, XrefRangeStart = 1425639, XrefRangeEnd = 1425642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_serverTime));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100670192);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100670193);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_serverTime;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<ServerTime>.Runtime runtime_serverTime;

          static Runtimes()
          {
            Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_serverTime));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1/ProjectM.RunWithoutJobSystem_00001065$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00001065$PostfixBurstDelegate");
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670194);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670195);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670196);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670197);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1/ProjectM.RunWithoutJobSystem_00001065$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425643, XrefRangeEnd = 1425657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425657, XrefRangeEnd = 1425675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425675, XrefRangeEnd = 1425690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425717, RefRangeEnd = 1425718, XrefRangeStart = 1425690, XrefRangeEnd = 1425717, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1>.NativeClassPtr, "RunWithoutJobSystem_00001065$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670198);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670199);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670200);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670201);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670203);
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
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob1.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_newServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public double newServerTime;
      [FieldOffset(8)]
      public VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425829, XrefRangeEnd = 1425833, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref DayNightCycle cycle)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref cycle;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1142695, RefRangeEnd = 1142697, XrefRangeStart = 1142695, XrefRangeEnd = 1142697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1142697, RefRangeEnd = 1142699, XrefRangeStart = 1142697, XrefRangeEnd = 1142699, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425833, XrefRangeEnd = 1425835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425840, RefRangeEnd = 1425841, XrefRangeStart = 1425835, XrefRangeEnd = 1425840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425843, RefRangeEnd = 1425844, XrefRangeStart = 1425841, XrefRangeEnd = 1425843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VariousMigratedDebugEventsSystem componentSystem,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425844, XrefRangeEnd = 1425848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425848, XrefRangeEnd = 1425854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr_newServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, nameof (newServerTime));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, nameof (_runtimes));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DayNightCycle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, 100670204);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, 100670205);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, 100670206);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, 100670207);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, 100670208);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, 100670209);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, 100670210);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, 100670211);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_cycle;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<DayNightCycle> forParameter_cycle;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425749, RefRangeEnd = 1425750, XrefRangeStart = 1425746, XrefRangeEnd = 1425749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VariousMigratedDebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425753, RefRangeEnd = 1425754, XrefRangeStart = 1425750, XrefRangeEnd = 1425753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_cycle));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100670212);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, 100670213);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_cycle;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<DayNightCycle>.Runtime runtime_cycle;

          static Runtimes()
          {
            Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_cycle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_cycle));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2/ProjectM.RunWithoutJobSystem_0000106E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_0000106E$PostfixBurstDelegate");
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670214);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670215);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670216);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670217);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2/ProjectM.RunWithoutJobSystem_0000106E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425754, XrefRangeEnd = 1425768, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425768, XrefRangeEnd = 1425786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425786, XrefRangeEnd = 1425801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425828, RefRangeEnd = 1425829, XrefRangeStart = 1425801, XrefRangeEnd = 1425828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2>.NativeClassPtr, "RunWithoutJobSystem_0000106E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670218);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670219);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670220);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670221);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670223);
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
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob2.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Age_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float time;
      [FieldOffset(8)]
      public VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425937, RefRangeEnd = 1425938, XrefRangeStart = 1425937, XrefRangeEnd = 1425937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref Age age)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref age;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Age_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1425938, RefRangeEnd = 1425941, XrefRangeStart = 1425938, XrefRangeEnd = 1425938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1425941, RefRangeEnd = 1425944, XrefRangeStart = 1425941, XrefRangeEnd = 1425941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425944, XrefRangeEnd = 1425946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425951, RefRangeEnd = 1425952, XrefRangeStart = 1425946, XrefRangeEnd = 1425951, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1425954, RefRangeEnd = 1425955, XrefRangeStart = 1425952, XrefRangeEnd = 1425954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VariousMigratedDebugEventsSystem componentSystem,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425955, XrefRangeEnd = 1425959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425959, XrefRangeEnd = 1425965, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, nameof (time));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, nameof (_runtimes));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Age_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, 100670224);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, 100670225);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, 100670226);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, 100670227);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, 100670228);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, 100670229);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, 100670230);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, 100670231);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_age;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<Age> forParameter_age;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425857, RefRangeEnd = 1425858, XrefRangeStart = 1425854, XrefRangeEnd = 1425857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VariousMigratedDebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425861, RefRangeEnd = 1425862, XrefRangeStart = 1425858, XrefRangeEnd = 1425861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_age));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100670232);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, 100670233);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_age;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<Age>.Runtime runtime_age;

          static Runtimes()
          {
            Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_age));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3/ProjectM.RunWithoutJobSystem_00001077$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00001077$PostfixBurstDelegate");
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670234);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670235);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670236);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670237);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3/ProjectM.RunWithoutJobSystem_00001077$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425862, XrefRangeEnd = 1425876, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425876, XrefRangeEnd = 1425894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425894, XrefRangeEnd = 1425909, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425936, RefRangeEnd = 1425937, XrefRangeStart = 1425909, XrefRangeEnd = 1425936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3>.NativeClassPtr, "RunWithoutJobSystem_00001077$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670238);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670239);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670240);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670241);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670243);
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
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob3.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float time;
      [FieldOffset(8)]
      public VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(48)]
      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426048, XrefRangeEnd = 1426057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        ref DynamicBuffer<ActiveServantMission> activeServantMissions)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeServantMissions;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1425938, RefRangeEnd = 1425941, XrefRangeStart = 1425938, XrefRangeEnd = 1425941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1425941, RefRangeEnd = 1425944, XrefRangeStart = 1425941, XrefRangeEnd = 1425944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426057, XrefRangeEnd = 1426059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426064, RefRangeEnd = 1426065, XrefRangeStart = 1426059, XrefRangeEnd = 1426064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426067, RefRangeEnd = 1426068, XrefRangeStart = 1426065, XrefRangeEnd = 1426067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VariousMigratedDebugEventsSystem componentSystem,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426068, XrefRangeEnd = 1426072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426072, XrefRangeEnd = 1426078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, nameof (time));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, nameof (_runtimes));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, 100670244);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, 100670245);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, 100670246);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, 100670247);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, 100670248);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, 100670249);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, 100670250);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, 100670251);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeServantMissions;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<ActiveServantMission> forParameter_activeServantMissions;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425968, RefRangeEnd = 1425969, XrefRangeStart = 1425965, XrefRangeEnd = 1425968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VariousMigratedDebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1425972, RefRangeEnd = 1425973, XrefRangeStart = 1425969, XrefRangeEnd = 1425972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeServantMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeServantMissions));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100670252);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, 100670253);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeServantMissions;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<ActiveServantMission>.Runtime runtime_activeServantMissions;

          static Runtimes()
          {
            Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeServantMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeServantMissions));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4/ProjectM.RunWithoutJobSystem_00001080$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_00001080$PostfixBurstDelegate");
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670254);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670255);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670256);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670257);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4/ProjectM.RunWithoutJobSystem_00001080$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425973, XrefRangeEnd = 1425987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1425987, XrefRangeEnd = 1426005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426005, XrefRangeEnd = 1426020, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426047, RefRangeEnd = 1426048, XrefRangeStart = 1426020, XrefRangeEnd = 1426047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4>.NativeClassPtr, "RunWithoutJobSystem_00001080$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670258);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670259);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670260);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670261);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670263);
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
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob4.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_time;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServantCoffinstation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public float time;
      [FieldOffset(8)]
      public VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426162, RefRangeEnd = 1426163, XrefRangeStart = 1426161, XrefRangeEnd = 1426162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref ServantCoffinstation servantCoffinStation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref servantCoffinStation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServantCoffinstation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1425938, RefRangeEnd = 1425941, XrefRangeStart = 1425938, XrefRangeEnd = 1425941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1425941, RefRangeEnd = 1425944, XrefRangeStart = 1425941, XrefRangeEnd = 1425944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426163, XrefRangeEnd = 1426165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426170, RefRangeEnd = 1426171, XrefRangeStart = 1426165, XrefRangeEnd = 1426170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426173, RefRangeEnd = 1426174, XrefRangeStart = 1426171, XrefRangeEnd = 1426173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VariousMigratedDebugEventsSystem componentSystem,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass8_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426174, XrefRangeEnd = 1426178, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426178, XrefRangeEnd = 1426184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, nameof (time));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, nameof (_runtimes));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_ServantCoffinstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, 100670264);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, 100670265);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, 100670266);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, 100670267);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, 100670268);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, 100670269);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, 100670270);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, 100670271);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_servantCoffinStation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<ServantCoffinstation> forParameter_servantCoffinStation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426081, RefRangeEnd = 1426082, XrefRangeStart = 1426078, XrefRangeEnd = 1426081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VariousMigratedDebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426085, RefRangeEnd = 1426086, XrefRangeStart = 1426082, XrefRangeEnd = 1426085, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_servantCoffinStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_servantCoffinStation));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, 100670272);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, 100670273);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_servantCoffinStation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<ServantCoffinstation>.Runtime runtime_servantCoffinStation;

          static Runtimes()
          {
            Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_servantCoffinStation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_servantCoffinStation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5/ProjectM.RunWithoutJobSystem_00001089$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, "RunWithoutJobSystem_00001089$PostfixBurstDelegate");
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670274);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670275);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670276);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670277);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5/ProjectM.RunWithoutJobSystem_00001089$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426086, XrefRangeEnd = 1426100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426100, XrefRangeEnd = 1426118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426118, XrefRangeEnd = 1426133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426160, RefRangeEnd = 1426161, XrefRangeStart = 1426133, XrefRangeEnd = 1426160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5>.NativeClassPtr, "RunWithoutJobSystem_00001089$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670278);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670279);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670280);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670281);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670283);
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
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleSetTimeOfDayEvent_LambdaJob5.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0")]
    public sealed class __c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_fromCharacter;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_equipmentType;
      private static readonly System.IntPtr NativeFieldInfoPtr_amount;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426235, RefRangeEnd = 1426236, XrefRangeStart = 1426200, XrefRangeEnd = 1426235, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref User user,
        [In] ref Controller controller)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref controller;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426237, RefRangeEnd = 1426238, XrefRangeStart = 1426236, XrefRangeEnd = 1426237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426239, RefRangeEnd = 1426240, XrefRangeStart = 1426238, XrefRangeEnd = 1426239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426240, XrefRangeEnd = 1426242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void Execute(
        ArchetypeChunk chunk,
        int chunkIndex,
        int firstEntityIndex)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426251, RefRangeEnd = 1426252, XrefRangeStart = 1426242, XrefRangeEnd = 1426251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426254, RefRangeEnd = 1426255, XrefRangeStart = 1426252, XrefRangeEnd = 1426254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VariousMigratedDebugEventsSystem componentSystem,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426255, XrefRangeEnd = 1426261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, nameof (fromCharacter));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, "<>4__this");
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_equipmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, nameof (equipmentType));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, nameof (amount));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_byref_Controller_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, 100670284);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, 100670285);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, 100670286);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, 100670287);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, 100670288);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, 100670289);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, 100670290);
      }

      public __c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe FromCharacter fromCharacter
      {
        get
        {
          return *(FromCharacter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_fromCharacter));
        }
        [param: In] set
        {
          *(FromCharacter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_fromCharacter)) = value;
        }
      }

      public unsafe VariousMigratedDebugEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (VariousMigratedDebugEventsSystem) null : new VariousMigratedDebugEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EquipmentType equipmentType
      {
        get
        {
          return *(EquipmentType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_equipmentType));
        }
        [param: In] set
        {
          *(EquipmentType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_equipmentType)) = value;
        }
      }

      public unsafe float amount
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_amount));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_amount)) = value;
        }
      }

      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_controller;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Controller> forParameter_controller;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426191, RefRangeEnd = 1426192, XrefRangeStart = 1426184, XrefRangeEnd = 1426191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VariousMigratedDebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426199, RefRangeEnd = 1426200, XrefRangeStart = 1426192, XrefRangeEnd = 1426199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_controller));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100670291);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100670292);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_controller;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Controller>.Runtime runtime_controller;

          static Runtimes()
          {
            Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_controller));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_HandleChangeDurabilityEvent_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_characterName;
      private static readonly System.IntPtr NativeFieldInfoPtr_e;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass12_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public FixedString64 characterName;
      [FieldOffset(64)]
      public Entity e;
      [FieldOffset(72)]
      public VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426347, RefRangeEnd = 1426348, XrefRangeStart = 1426346, XrefRangeEnd = 1426347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref User user)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref user;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426348, RefRangeEnd = 1426349, XrefRangeStart = 1426348, XrefRangeEnd = 1426348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426349, RefRangeEnd = 1426350, XrefRangeStart = 1426349, XrefRangeEnd = 1426349, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426350, XrefRangeEnd = 1426352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426358, RefRangeEnd = 1426359, XrefRangeStart = 1426352, XrefRangeEnd = 1426358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1426361, RefRangeEnd = 1426362, XrefRangeStart = 1426359, XrefRangeEnd = 1426361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        VariousMigratedDebugEventsSystem componentSystem,
        ref VariousMigratedDebugEventsSystem.__c__DisplayClass12_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass12_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426362, XrefRangeEnd = 1426366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426366, XrefRangeEnd = 1426372, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0()
      {
        Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem>.NativeClassPtr, "<>c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr_characterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, nameof (characterName));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr_e = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, nameof (e));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_User_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, 100670293);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, 100670294);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, 100670295);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, 100670296);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, 100670297);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, 100670298);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, 100670299);
        VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, 100670300);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_user;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<User> forParameter_user;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426265, RefRangeEnd = 1426266, XrefRangeStart = 1426261, XrefRangeEnd = 1426265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(VariousMigratedDebugEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426270, RefRangeEnd = 1426271, XrefRangeStart = 1426266, XrefRangeEnd = 1426270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_user));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_VariousMigratedDebugEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100670301);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100670302);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_user;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<User>.Runtime runtime_user;

          static Runtimes()
          {
            Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_user = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_user));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0/ProjectM.RunWithoutJobSystem_0000109B$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000109B$PostfixBurstDelegate");
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670303);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670304);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670305);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100670306);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.VariousMigratedDebugEventsSystem/ProjectM.<>c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0/ProjectM.RunWithoutJobSystem_0000109B$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426271, XrefRangeEnd = 1426285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426285, XrefRangeEnd = 1426303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426303, XrefRangeEnd = 1426318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1426345, RefRangeEnd = 1426346, XrefRangeStart = 1426318, XrefRangeEnd = 1426345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_0000109B$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670307);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670308);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670309);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670310);
          VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100670312);
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
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(VariousMigratedDebugEventsSystem.__c__DisplayClass_TryFindUserWithCharacterName_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
