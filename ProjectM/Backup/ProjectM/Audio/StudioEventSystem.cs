// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.StudioEventSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using FMOD;
using FMOD.Studio;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Entities.UniversalDelegates;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Audio
{
  public class StudioEventSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NewAudioEventsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyedAudioEventsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DisabledAudioEventsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__StudioManagerSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__ProgrammerSoundCallback;
    private static readonly System.IntPtr NativeFieldInfoPtr_LogSounds;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnDestroy_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnDestroy_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateEventInstances_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateEventInstances_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___PullAndUpdateSoundTranslations_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___PullAndUpdateSoundTranslations_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetEvent3DPositions_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetEvent3DPositions_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateParameters_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateParameters_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddRemoveEvents_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddRemoveEvents_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddRemoveEvents_LambdaJob1_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddRemoveEvents_LambdaJob1_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPerformanceStatsUsage_Public_Void_byref_Single_byref_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddRemoveEvents_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveEvents_Private_Void_byref_StudioEventInstance_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProgrammerSoundCallback_Private_Static_RESULT_EVENT_CALLBACK_TYPE_IntPtr_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ErrorCheck_Private_Static_Boolean_RESULT_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintSoundState_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnDestroy_b__8_0_Private_Void_byref_StudioEventInstance_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddRemoveEvents_b__11_0_Private_Void_byref_StudioEventInstance_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__AddRemoveEvents_b__11_1_Private_Void_byref_StudioEventInstance_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnDestroy_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateEventInstances_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForPullAndUpdateSoundTranslations_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetEvent3DPositions_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateParameters_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAddRemoveEvents_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAddRemoveEvents_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_2;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142962, XrefRangeEnd = 1143006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StudioEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143006, XrefRangeEnd = 1143018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StudioEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1143023, RefRangeEnd = 1143024, XrefRangeStart = 1143018, XrefRangeEnd = 1143023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetPerformanceStatsUsage(out float cpuInMs, out int memoryInMb)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref cpuInMs;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref memoryInMb;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_GetPerformanceStatsUsage_Public_Void_byref_Single_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143024, XrefRangeEnd = 1143100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StudioEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1143194, RefRangeEnd = 1143195, XrefRangeStart = 1143100, XrefRangeEnd = 1143194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddRemoveEvents()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_AddRemoveEvents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1143203, RefRangeEnd = 1143206, XrefRangeStart = 1143195, XrefRangeEnd = 1143203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveEvents(
      ref StudioEventInstance eventInstance,
      bool logOnInvalidInstance = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref eventInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &logOnInvalidInstance;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_RemoveEvents_Private_Void_byref_StudioEventInstance_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143206, XrefRangeEnd = 1143248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe RESULT ProgrammerSoundCallback(
      EVENT_CALLBACK_TYPE type,
      System.IntPtr _event,
      System.IntPtr parameters)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_event;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &parameters;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_ProgrammerSoundCallback_Private_Static_RESULT_EVENT_CALLBACK_TYPE_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RESULT*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1143292, RefRangeEnd = 1143294, XrefRangeStart = 1143248, XrefRangeEnd = 1143292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ErrorCheck(RESULT result, string sender, Il2CppSystem.Object attachedLogData = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sender);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) attachedLogData);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_ErrorCheck_Private_Static_Boolean_RESULT_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1143387, RefRangeEnd = 1143388, XrefRangeStart = 1143294, XrefRangeEnd = 1143387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void PrintSoundState()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_PrintSoundState_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StudioEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1143389, RefRangeEnd = 1143390, XrefRangeStart = 1143388, XrefRangeEnd = 1143389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnDestroy_b__8_0(ref StudioEventInstance audioEventInstance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref audioEventInstance;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr__OnDestroy_b__8_0_Private_Void_byref_StudioEventInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1143391, RefRangeEnd = 1143393, XrefRangeStart = 1143390, XrefRangeEnd = 1143391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _AddRemoveEvents_b__11_0(ref StudioEventInstance audioEventInstance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref audioEventInstance;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr__AddRemoveEvents_b__11_0_Private_Void_byref_StudioEventInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1143391, RefRangeEnd = 1143393, XrefRangeStart = 1143391, XrefRangeEnd = 1143393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _AddRemoveEvents_b__11_1(ref StudioEventInstance audioEventInstance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref audioEventInstance;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr__AddRemoveEvents_b__11_1_Private_Void_byref_StudioEventInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143393, XrefRangeEnd = 1143623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), StudioEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143623, XrefRangeEnd = 1143639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnDestroy_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnDestroy_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143639, XrefRangeEnd = 1143655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateEventInstances_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateEventInstances_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143655, XrefRangeEnd = 1143674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143674, XrefRangeEnd = 1143693, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForPullAndUpdateSoundTranslations_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForPullAndUpdateSoundTranslations_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143693, XrefRangeEnd = 1143712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetEvent3DPositions_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetEvent3DPositions_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143712, XrefRangeEnd = 1143731, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateParameters_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateParameters_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143731, XrefRangeEnd = 1143750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAddRemoveEvents_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddRemoveEvents_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1143772, RefRangeEnd = 1143773, XrefRangeStart = 1143750, XrefRangeEnd = 1143772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAddRemoveEvents_LambdaJob1_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddRemoveEvents_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1143777, RefRangeEnd = 1143778, XrefRangeStart = 1143773, XrefRangeEnd = 1143777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1143782, RefRangeEnd = 1143783, XrefRangeStart = 1143778, XrefRangeEnd = 1143782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1143787, RefRangeEnd = 1143788, XrefRangeStart = 1143783, XrefRangeEnd = 1143787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_2()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static StudioEventSystem()
    {
      Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (StudioEventSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr);
      StudioEventSystem.NativeFieldInfoPtr__NewAudioEventsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, nameof (_NewAudioEventsQuery));
      StudioEventSystem.NativeFieldInfoPtr__DestroyedAudioEventsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, nameof (_DestroyedAudioEventsQuery));
      StudioEventSystem.NativeFieldInfoPtr__DisabledAudioEventsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, nameof (_DisabledAudioEventsQuery));
      StudioEventSystem.NativeFieldInfoPtr__StudioManagerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, nameof (_StudioManagerSystem));
      StudioEventSystem.NativeFieldInfoPtr__ProgrammerSoundCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, nameof (_ProgrammerSoundCallback));
      StudioEventSystem.NativeFieldInfoPtr_LogSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, nameof (LogSounds));
      StudioEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      StudioEventSystem.NativeFieldInfoPtr___OnDestroy_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>OnDestroy_LambdaJob0_entityQuery");
      StudioEventSystem.NativeFieldInfoPtr___OnDestroy_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>OnDestroy_LambdaJob0_profilerMarker");
      StudioEventSystem.NativeFieldInfoPtr___UpdateEventInstances_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>UpdateEventInstances_entityQuery");
      StudioEventSystem.NativeFieldInfoPtr___UpdateEventInstances_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>UpdateEventInstances_profilerMarker");
      StudioEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_entityQuery");
      StudioEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob1_profilerMarker");
      StudioEventSystem.NativeFieldInfoPtr___PullAndUpdateSoundTranslations_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>PullAndUpdateSoundTranslations_entityQuery");
      StudioEventSystem.NativeFieldInfoPtr___PullAndUpdateSoundTranslations_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>PullAndUpdateSoundTranslations_profilerMarker");
      StudioEventSystem.NativeFieldInfoPtr___SetEvent3DPositions_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>SetEvent3DPositions_entityQuery");
      StudioEventSystem.NativeFieldInfoPtr___SetEvent3DPositions_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>SetEvent3DPositions_profilerMarker");
      StudioEventSystem.NativeFieldInfoPtr___UpdateParameters_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>UpdateParameters_entityQuery");
      StudioEventSystem.NativeFieldInfoPtr___UpdateParameters_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>UpdateParameters_profilerMarker");
      StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>AddRemoveEvents_LambdaJob0_entityQuery");
      StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>AddRemoveEvents_LambdaJob0_profilerMarker");
      StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob1_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>AddRemoveEvents_LambdaJob1_entityQuery");
      StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob1_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>AddRemoveEvents_LambdaJob1_profilerMarker");
      StudioEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690405);
      StudioEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690406);
      StudioEventSystem.NativeMethodInfoPtr_GetPerformanceStatsUsage_Public_Void_byref_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690407);
      StudioEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690408);
      StudioEventSystem.NativeMethodInfoPtr_AddRemoveEvents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690409);
      StudioEventSystem.NativeMethodInfoPtr_RemoveEvents_Private_Void_byref_StudioEventInstance_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690410);
      StudioEventSystem.NativeMethodInfoPtr_ProgrammerSoundCallback_Private_Static_RESULT_EVENT_CALLBACK_TYPE_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690411);
      StudioEventSystem.NativeMethodInfoPtr_ErrorCheck_Private_Static_Boolean_RESULT_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690412);
      StudioEventSystem.NativeMethodInfoPtr_PrintSoundState_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690413);
      StudioEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690414);
      StudioEventSystem.NativeMethodInfoPtr__OnDestroy_b__8_0_Private_Void_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690415);
      StudioEventSystem.NativeMethodInfoPtr__AddRemoveEvents_b__11_0_Private_Void_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690416);
      StudioEventSystem.NativeMethodInfoPtr__AddRemoveEvents_b__11_1_Private_Void_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690417);
      StudioEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690418);
      StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnDestroy_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690419);
      StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateEventInstances_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690420);
      StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690421);
      StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForPullAndUpdateSoundTranslations_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690422);
      StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForSetEvent3DPositions_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690423);
      StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateParameters_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690424);
      StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddRemoveEvents_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690425);
      StudioEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForAddRemoveEvents_LambdaJob1_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690426);
      StudioEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690427);
      StudioEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690428);
      StudioEventSystem.NativeMethodInfoPtr_Method_Public_Static_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, 100690429);
    }

    public StudioEventSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _NewAudioEventsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__NewAudioEventsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__NewAudioEventsQuery)) = value;
      }
    }

    public unsafe EntityQuery _DestroyedAudioEventsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__DestroyedAudioEventsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__DestroyedAudioEventsQuery)) = value;
      }
    }

    public unsafe EntityQuery _DisabledAudioEventsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__DisabledAudioEventsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__DisabledAudioEventsQuery)) = value;
      }
    }

    public static unsafe StudioManagerSystem _StudioManagerSystem
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.NativeFieldInfoPtr__StudioManagerSystem, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (StudioManagerSystem) null : new StudioManagerSystem(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.NativeFieldInfoPtr__StudioManagerSystem, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EVENT_CALLBACK _ProgrammerSoundCallback
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__ProgrammerSoundCallback));
        return pointer == System.IntPtr.Zero ? (EVENT_CALLBACK) null : new EVENT_CALLBACK(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__ProgrammerSoundCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool LogSounds
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr_LogSounds));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr_LogSounds)) = value;
      }
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnDestroy_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___OnDestroy_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___OnDestroy_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnDestroy_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___OnDestroy_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___OnDestroy_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateEventInstances_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___UpdateEventInstances_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___UpdateEventInstances_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateEventInstances_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___UpdateEventInstances_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___UpdateEventInstances_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob1_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __PullAndUpdateSoundTranslations_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___PullAndUpdateSoundTranslations_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___PullAndUpdateSoundTranslations_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __PullAndUpdateSoundTranslations_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___PullAndUpdateSoundTranslations_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___PullAndUpdateSoundTranslations_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __SetEvent3DPositions_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___SetEvent3DPositions_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___SetEvent3DPositions_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetEvent3DPositions_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___SetEvent3DPositions_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___SetEvent3DPositions_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __UpdateParameters_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___UpdateParameters_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___UpdateParameters_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateParameters_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___UpdateParameters_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___UpdateParameters_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __AddRemoveEvents_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AddRemoveEvents_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __AddRemoveEvents_LambdaJob1_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob1_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob1_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AddRemoveEvents_LambdaJob1_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob1_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.NativeFieldInfoPtr___AddRemoveEvents_LambdaJob1_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/<>c__DisplayClass10_0")]
    public sealed class __c__DisplayClass10_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_StudioEventInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_StudioEventInstance_byref_StudioEventUpdatePosition_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass10_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, ref StudioEventInstance eventInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_StudioEventInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity entity,
        DynamicBuffer<StudioEventParameterBuffer> parameterBuffer,
        [In] ref StudioEventInstance eventInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parameterBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(
        Entity entity,
        [In] ref StudioEventInstance eventInstance,
        [In] ref StudioEventUpdatePosition studioPositionData)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref studioPositionData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_StudioEventInstance_byref_StudioEventUpdatePosition_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass10_0()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass10_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
        StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (commandBuffer));
        StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, nameof (entityManager));
        StudioEventSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, 100690430);
        StudioEventSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, 100690431);
        StudioEventSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, 100690432);
        StudioEventSystem.__c__DisplayClass10_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_Entity_byref_StudioEventInstance_byref_StudioEventUpdatePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, 100690433);
      }

      public __c__DisplayClass10_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass10_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass10_0>.NativeClassPtr, data));
      }

      public unsafe StudioEventSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StudioEventSystem) null : new StudioEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass10_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__10_3;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__10_4;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__10_3_Internal_Void_byref_StudioEventInstance_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__10_4_Internal_Void_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__10_3(
        [In] ref StudioEventInstance eventInstance,
        [In] ref LocalToWorld localToWorld)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c.NativeMethodInfoPtr__OnUpdate_b__10_3_Internal_Void_byref_StudioEventInstance_byref_LocalToWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__10_4(
        DynamicBuffer<StudioEventParameterBuffer> parameterBuffer,
        [In] ref StudioEventInstance eventInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &parameterBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c.NativeMethodInfoPtr__OnUpdate_b__10_4_Internal_Void_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr);
        StudioEventSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr, "<>9");
        StudioEventSystem.__c.NativeFieldInfoPtr___9__10_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr, "<>9__10_3");
        StudioEventSystem.__c.NativeFieldInfoPtr___9__10_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr, "<>9__10_4");
        StudioEventSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr, 100690435);
        StudioEventSystem.__c.NativeMethodInfoPtr__OnUpdate_b__10_3_Internal_Void_byref_StudioEventInstance_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr, 100690436);
        StudioEventSystem.__c.NativeMethodInfoPtr__OnUpdate_b__10_4_Internal_Void_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c>.NativeClassPtr, 100690437);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe StudioEventSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StudioEventSystem.__c) null : new StudioEventSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe II<StudioEventInstance, LocalToWorld> __9__10_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c.NativeFieldInfoPtr___9__10_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (II<StudioEventInstance, LocalToWorld>) null : new II<StudioEventInstance, LocalToWorld>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c.NativeFieldInfoPtr___9__10_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe VI<DynamicBuffer<StudioEventParameterBuffer>, StudioEventInstance> __9__10_4
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c.NativeFieldInfoPtr___9__10_4, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VI<DynamicBuffer<StudioEventParameterBuffer>, StudioEventInstance>) null : new VI<DynamicBuffer<StudioEventParameterBuffer>, StudioEventInstance>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c.NativeFieldInfoPtr___9__10_4, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_OnDestroy_LambdaJob0")]
    public sealed class __c__DisplayClass_OnDestroy_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142353, RefRangeEnd = 1142354, XrefRangeStart = 1142351, XrefRangeEnd = 1142353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StudioEventInstance audioEventInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref audioEventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142354, XrefRangeEnd = 1142356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142361, RefRangeEnd = 1142362, XrefRangeStart = 1142356, XrefRangeEnd = 1142361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142364, RefRangeEnd = 1142365, XrefRangeStart = 1142362, XrefRangeEnd = 1142364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142365, XrefRangeEnd = 1142371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnDestroy_LambdaJob0()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass_OnDestroy_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, 100690438);
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, 100690439);
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, 100690440);
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, 100690441);
        StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, 100690442);
      }

      public __c__DisplayClass_OnDestroy_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnDestroy_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe StudioEventSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (StudioEventSystem) null : new StudioEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_audioEventInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StudioEventInstance> forParameter_audioEventInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142346, RefRangeEnd = 1142347, XrefRangeStart = 1142343, XrefRangeEnd = 1142346, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142350, RefRangeEnd = 1142351, XrefRangeStart = 1142347, XrefRangeEnd = 1142350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_audioEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_audioEventInstance));
          StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100690443);
          StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100690444);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_audioEventInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StudioEventInstance>.Runtime runtime_audioEventInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_audioEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_audioEventInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnDestroy_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_UpdateEventInstances")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateEventInstances
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_StudioEventDestroyOnCompletion_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StudioEventInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ComponentDataFromEntity<StudioEventDestroyOnCompletion> _ComponentDataFromEntity_StudioEventDestroyOnCompletion_0;
      [FieldOffset(48)]
      public StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142456, XrefRangeEnd = 1142482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref StudioEventInstance eventInstance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StudioEventInstance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723251, RefRangeEnd = 723285, XrefRangeStart = 723251, XrefRangeEnd = 723285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723285, RefRangeEnd = 723319, XrefRangeStart = 723285, XrefRangeEnd = 723319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142482, XrefRangeEnd = 1142484, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142490, RefRangeEnd = 1142491, XrefRangeStart = 1142484, XrefRangeEnd = 1142490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142496, RefRangeEnd = 1142497, XrefRangeStart = 1142491, XrefRangeEnd = 1142496, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StudioEventSystem componentSystem,
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142497, XrefRangeEnd = 1142501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142501, XrefRangeEnd = 1142507, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateEventInstances()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateEventInstances");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, nameof (commandBuffer));
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr__ComponentDataFromEntity_StudioEventDestroyOnCompletion_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, nameof (_ComponentDataFromEntity_StudioEventDestroyOnCompletion_0));
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, nameof (_runtimes));
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, 100690445);
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, 100690446);
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, 100690447);
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, 100690448);
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, 100690449);
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, 100690450);
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, 100690451);
        StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, 100690452);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<StudioEventInstance> forParameter_eventInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142375, RefRangeEnd = 1142376, XrefRangeStart = 1142371, XrefRangeEnd = 1142375, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142380, RefRangeEnd = 1142381, XrefRangeStart = 1142376, XrefRangeEnd = 1142380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventInstance));
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders>.NativeClassPtr, 100690453);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders>.NativeClassPtr, 100690454);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<StudioEventInstance>.Runtime runtime_eventInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_UpdateEventInstances/ProjectM.Audio.RunWithoutJobSystem_00005E64$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, "RunWithoutJobSystem_00005E64$PostfixBurstDelegate");
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690455);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690456);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690457);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690458);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_UpdateEventInstances/ProjectM.Audio.RunWithoutJobSystem_00005E64$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142381, XrefRangeEnd = 1142395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142395, XrefRangeEnd = 1142413, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142413, XrefRangeEnd = 1142428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142455, RefRangeEnd = 1142456, XrefRangeStart = 1142428, XrefRangeEnd = 1142455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances>.NativeClassPtr, "RunWithoutJobSystem_00005E64$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690459);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690460);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690461);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690462);
          StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690464);
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
            IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_UpdateEventInstances.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_OnUpdate_LambdaJob1")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142568, RefRangeEnd = 1142569, XrefRangeStart = 1142523, XrefRangeEnd = 1142568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        DynamicBuffer<StudioEventParameterBuffer> parameterBuffer,
        [In] ref StudioEventInstance eventInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &parameterBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(18)]
      [CachedScanResults(RefRangeStart = 755322, RefRangeEnd = 755340, XrefRangeStart = 755322, XrefRangeEnd = 755340, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(24)]
      [CachedScanResults(RefRangeStart = 755341, RefRangeEnd = 755365, XrefRangeStart = 755341, XrefRangeEnd = 755365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142569, XrefRangeEnd = 1142571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142580, RefRangeEnd = 1142581, XrefRangeStart = 1142571, XrefRangeEnd = 1142580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142583, RefRangeEnd = 1142584, XrefRangeStart = 1142581, XrefRangeEnd = 1142583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StudioEventSystem componentSystem,
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142584, XrefRangeEnd = 1142590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, "<>4__this");
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100690465);
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100690466);
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100690467);
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100690468);
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100690469);
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100690470);
        StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, 100690471);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, data));
      }

      public unsafe StudioEventSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (StudioEventSystem) null : new StudioEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_parameterBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<StudioEventParameterBuffer> forParameter_parameterBuffer;
        [FieldOffset(48)]
        public LambdaParameterValueProvider_IComponentData<StudioEventInstance> forParameter_eventInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142514, RefRangeEnd = 1142515, XrefRangeStart = 1142507, XrefRangeEnd = 1142514, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142522, RefRangeEnd = 1142523, XrefRangeStart = 1142515, XrefRangeEnd = 1142522, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_parameterBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_parameterBuffer));
          StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventInstance));
          StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100690472);
          StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100690473);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_parameterBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<StudioEventParameterBuffer>.Runtime runtime_parameterBuffer;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<StudioEventInstance>.Runtime runtime_eventInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parameterBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_parameterBuffer));
            StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_OnUpdate_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_PullAndUpdateSoundTranslations")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_PullAndUpdateSoundTranslations
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StudioEventInstance_byref_StudioEventUpdatePosition_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(80)]
      public unsafe StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142681, XrefRangeEnd = 1142695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref StudioEventInstance eventInstance,
        [In] ref StudioEventUpdatePosition studioPositionData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref studioPositionData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StudioEventInstance_byref_StudioEventUpdatePosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1142695, RefRangeEnd = 1142697, XrefRangeStart = 1142695, XrefRangeEnd = 1142695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1142697, RefRangeEnd = 1142699, XrefRangeStart = 1142697, XrefRangeEnd = 1142697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142699, XrefRangeEnd = 1142701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142710, RefRangeEnd = 1142711, XrefRangeStart = 1142701, XrefRangeEnd = 1142710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142713, RefRangeEnd = 1142714, XrefRangeStart = 1142711, XrefRangeEnd = 1142713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        StudioEventSystem componentSystem,
        ref StudioEventSystem.__c__DisplayClass10_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142714, XrefRangeEnd = 1142718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142718, XrefRangeEnd = 1142724, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_PullAndUpdateSoundTranslations()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass_PullAndUpdateSoundTranslations");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, nameof (entityManager));
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, nameof (_runtimes));
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_StudioEventInstance_byref_StudioEventUpdatePosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, 100690474);
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, 100690475);
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, 100690476);
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, 100690477);
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, 100690478);
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_byref___c__DisplayClass10_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, 100690479);
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, 100690480);
        StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, 100690481);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventInstance;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_studioPositionData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<StudioEventInstance> forParameter_eventInstance;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<StudioEventUpdatePosition> forParameter_studioPositionData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142597, RefRangeEnd = 1142598, XrefRangeStart = 1142590, XrefRangeEnd = 1142597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142605, RefRangeEnd = 1142606, XrefRangeStart = 1142598, XrefRangeEnd = 1142605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventInstance));
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_studioPositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_studioPositionData));
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders>.NativeClassPtr, 100690482);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders>.NativeClassPtr, 100690483);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventInstance;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_studioPositionData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<StudioEventInstance>.Runtime runtime_eventInstance;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<StudioEventUpdatePosition>.Runtime runtime_studioPositionData;

          static Runtimes()
          {
            Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventInstance));
            StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_studioPositionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_studioPositionData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_PullAndUpdateSoundTranslations/ProjectM.Audio.RunWithoutJobSystem_00005E76$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, "RunWithoutJobSystem_00005E76$PostfixBurstDelegate");
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690484);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690485);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690486);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690487);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_PullAndUpdateSoundTranslations/ProjectM.Audio.RunWithoutJobSystem_00005E76$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142606, XrefRangeEnd = 1142620, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142620, XrefRangeEnd = 1142638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142638, XrefRangeEnd = 1142653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142680, RefRangeEnd = 1142681, XrefRangeStart = 1142653, XrefRangeEnd = 1142680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations>.NativeClassPtr, "RunWithoutJobSystem_00005E76$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690488);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690489);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690490);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690491);
          StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690493);
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
            IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_PullAndUpdateSoundTranslations.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_SetEvent3DPositions")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SetEvent3DPositions
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StudioEventInstance_byref_LocalToWorld_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(64)]
      public unsafe StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142817, RefRangeEnd = 1142818, XrefRangeStart = 1142813, XrefRangeEnd = 1142817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref StudioEventInstance eventInstance,
        [In] ref LocalToWorld localToWorld)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref eventInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref localToWorld;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StudioEventInstance_byref_LocalToWorld_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142818, XrefRangeEnd = 1142820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142828, RefRangeEnd = 1142829, XrefRangeStart = 1142820, XrefRangeEnd = 1142828, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142830, RefRangeEnd = 1142831, XrefRangeStart = 1142829, XrefRangeEnd = 1142830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142831, XrefRangeEnd = 1142835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142835, XrefRangeEnd = 1142841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetEvent3DPositions()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass_SetEvent3DPositions");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, nameof (_runtimes));
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_StudioEventInstance_byref_LocalToWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, 100690494);
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, 100690495);
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, 100690496);
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, 100690497);
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, 100690498);
        StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, 100690499);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventInstance;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_localToWorld;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StudioEventInstance> forParameter_eventInstance;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<LocalToWorld> forParameter_localToWorld;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142730, RefRangeEnd = 1142731, XrefRangeStart = 1142724, XrefRangeEnd = 1142730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142737, RefRangeEnd = 1142738, XrefRangeStart = 1142731, XrefRangeEnd = 1142737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventInstance));
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_localToWorld));
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders>.NativeClassPtr, 100690500);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders>.NativeClassPtr, 100690501);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventInstance;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_localToWorld;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StudioEventInstance>.Runtime runtime_eventInstance;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<LocalToWorld>.Runtime runtime_localToWorld;

          static Runtimes()
          {
            Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventInstance));
            StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_localToWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_localToWorld));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_SetEvent3DPositions/ProjectM.Audio.RunWithoutJobSystem_00005E7D$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, "RunWithoutJobSystem_00005E7D$PostfixBurstDelegate");
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690502);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690503);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690504);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100690505);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_SetEvent3DPositions/ProjectM.Audio.RunWithoutJobSystem_00005E7D$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142738, XrefRangeEnd = 1142752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142752, XrefRangeEnd = 1142770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142770, XrefRangeEnd = 1142785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142812, RefRangeEnd = 1142813, XrefRangeStart = 1142785, XrefRangeEnd = 1142812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions>.NativeClassPtr, "RunWithoutJobSystem_00005E7D$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690506);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690507);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690508);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690509);
          StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100690511);
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
            IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_SetEvent3DPositions.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_UpdateParameters")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateParameters
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142870, RefRangeEnd = 1142871, XrefRangeStart = 1142855, XrefRangeEnd = 1142870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        DynamicBuffer<StudioEventParameterBuffer> parameterBuffer,
        [In] ref StudioEventInstance eventInstance)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &parameterBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142871, XrefRangeEnd = 1142873, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142881, RefRangeEnd = 1142882, XrefRangeStart = 1142873, XrefRangeEnd = 1142881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142901, RefRangeEnd = 1142902, XrefRangeStart = 1142882, XrefRangeEnd = 1142901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142902, XrefRangeEnd = 1142908, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateParameters()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateParameters");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, nameof (_runtimes));
        StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_DynamicBuffer_1_StudioEventParameterBuffer_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, 100690512);
        StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, 100690513);
        StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, 100690514);
        StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, 100690515);
        StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, 100690516);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_UpdateParameters.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_parameterBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<StudioEventParameterBuffer> forParameter_parameterBuffer;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<StudioEventInstance> forParameter_eventInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142847, RefRangeEnd = 1142848, XrefRangeStart = 1142841, XrefRangeEnd = 1142847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142854, RefRangeEnd = 1142855, XrefRangeStart = 1142848, XrefRangeEnd = 1142854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_parameterBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_parameterBuffer));
          StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventInstance));
          StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders>.NativeClassPtr, 100690517);
          StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders>.NativeClassPtr, 100690518);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_parameterBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<StudioEventParameterBuffer>.Runtime runtime_parameterBuffer;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<StudioEventInstance>.Runtime runtime_eventInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parameterBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_parameterBuffer));
            StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_UpdateParameters.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_AddRemoveEvents_LambdaJob0")]
    public sealed class __c__DisplayClass_AddRemoveEvents_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1142918, RefRangeEnd = 1142920, XrefRangeStart = 1142916, XrefRangeEnd = 1142918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StudioEventInstance audioEventInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref audioEventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142920, XrefRangeEnd = 1142922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142927, RefRangeEnd = 1142928, XrefRangeStart = 1142922, XrefRangeEnd = 1142927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142930, RefRangeEnd = 1142931, XrefRangeStart = 1142928, XrefRangeEnd = 1142930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142931, XrefRangeEnd = 1142937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AddRemoveEvents_LambdaJob0()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass_AddRemoveEvents_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, nameof (hostInstance));
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, 100690519);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, 100690520);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, 100690521);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, 100690522);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, 100690523);
      }

      public __c__DisplayClass_AddRemoveEvents_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_AddRemoveEvents_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe StudioEventSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (StudioEventSystem) null : new StudioEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_audioEventInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StudioEventInstance> forParameter_audioEventInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142911, RefRangeEnd = 1142912, XrefRangeStart = 1142908, XrefRangeEnd = 1142911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142915, RefRangeEnd = 1142916, XrefRangeStart = 1142912, XrefRangeEnd = 1142915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_audioEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_audioEventInstance));
          StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100690524);
          StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100690525);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_audioEventInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StudioEventInstance>.Runtime runtime_audioEventInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_audioEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_audioEventInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Audio.StudioEventSystem/ProjectM.Audio.<>c__DisplayClass_AddRemoveEvents_LambdaJob1")]
    public sealed class __c__DisplayClass_AddRemoveEvents_LambdaJob1 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_hostInstance;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1142918, RefRangeEnd = 1142920, XrefRangeStart = 1142918, XrefRangeEnd = 1142920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref StudioEventInstance audioEventInstance)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref audioEventInstance;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142945, XrefRangeEnd = 1142947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142952, RefRangeEnd = 1142953, XrefRangeStart = 1142947, XrefRangeEnd = 1142952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1142955, RefRangeEnd = 1142956, XrefRangeStart = 1142953, XrefRangeEnd = 1142955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142956, XrefRangeEnd = 1142962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AddRemoveEvents_LambdaJob1()
      {
        Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem>.NativeClassPtr, "<>c__DisplayClass_AddRemoveEvents_LambdaJob1");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr_hostInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, nameof (hostInstance));
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, nameof (_runtimes));
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_OriginalLambdaBody_Public_Void_byref_StudioEventInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, 100690526);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, 100690527);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, 100690528);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, 100690529);
        StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, 100690530);
      }

      public __c__DisplayClass_AddRemoveEvents_LambdaJob1(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_AddRemoveEvents_LambdaJob1()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, data));
      }

      public unsafe StudioEventSystem hostInstance
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr_hostInstance));
          return pointer == System.IntPtr.Zero ? (StudioEventSystem) null : new StudioEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr_hostInstance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_audioEventInstance;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<StudioEventInstance> forParameter_audioEventInstance;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142940, RefRangeEnd = 1142941, XrefRangeStart = 1142937, XrefRangeEnd = 1142940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(StudioEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1142944, RefRangeEnd = 1142945, XrefRangeStart = 1142941, XrefRangeEnd = 1142944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_audioEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_audioEventInstance));
          StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_StudioEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100690531);
          StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, 100690532);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_audioEventInstance;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<StudioEventInstance>.Runtime runtime_audioEventInstance;

          static Runtimes()
          {
            Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_audioEventInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_audioEventInstance));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StudioEventSystem.__c__DisplayClass_AddRemoveEvents_LambdaJob1.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
