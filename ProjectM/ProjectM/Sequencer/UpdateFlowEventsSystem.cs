// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.UpdateFlowEventsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Rendering;

#nullable disable
namespace ProjectM.Sequencer
{
  public class UpdateFlowEventsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__LocalControlledAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateFlowEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateFlowEvents_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidatePlaybackSpeed_Private_Static_Boolean_byref_InputData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetPlaybackSpeedRecursive_Private_Static_Void_Int32_byref_InputData_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StartNodeRecursive_Private_Static_StartResult_byref_EventStruct_Int32_byref_InputData_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetStateRecursive_Private_Static_Void_Int32_byref_InputData_EventStateEnum_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateNodeRecursive_Private_Static_Boolean_byref_EventStruct_Int32_byref_InputData_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateFlowEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106205, XrefRangeEnd = 1106215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateFlowEventsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106215, XrefRangeEnd = 1106218, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateFlowEventsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106218, XrefRangeEnd = 1106257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateFlowEventsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1106257, RefRangeEnd = 1106258, XrefRangeStart = 1106257, XrefRangeEnd = 1106257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool ValidatePlaybackSpeed(ref InputData input, int eventCount)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &eventCount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.NativeMethodInfoPtr_ValidatePlaybackSpeed_Private_Static_Boolean_byref_InputData_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1106274, RefRangeEnd = 1106276, XrefRangeStart = 1106258, XrefRangeEnd = 1106274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetPlaybackSpeedRecursive(
      int nodeIndex,
      ref InputData input,
      float playbackSpeed)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &nodeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playbackSpeed;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.NativeMethodInfoPtr_SetPlaybackSpeedRecursive_Private_Static_Void_Int32_byref_InputData_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1106295, RefRangeEnd = 1106299, XrefRangeStart = 1106276, XrefRangeEnd = 1106295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe UpdateFlowEventsSystem.StartResult StartNodeRecursive(
      ref EventStruct eventState,
      int nodeIndex,
      ref InputData input,
      float startOffset)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref eventState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &startOffset;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.NativeMethodInfoPtr_StartNodeRecursive_Private_Static_StartResult_byref_EventStruct_Int32_byref_InputData_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(UpdateFlowEventsSystem.StartResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1106311, RefRangeEnd = 1106314, XrefRangeStart = 1106299, XrefRangeEnd = 1106311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void SetStateRecursive(
      int nodeIndex,
      ref InputData input,
      EventStateEnum state)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &nodeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &state;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.NativeMethodInfoPtr_SetStateRecursive_Private_Static_Void_Int32_byref_InputData_EventStateEnum_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 1106348, RefRangeEnd = 1106352, XrefRangeStart = 1106314, XrefRangeEnd = 1106348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool UpdateNodeRecursive(
      ref EventStruct eventState,
      int nodeIndex,
      ref InputData input,
      float deltaTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref eventState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nodeIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref input;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &deltaTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.NativeMethodInfoPtr_UpdateNodeRecursive_Private_Static_Boolean_byref_EventStruct_Int32_byref_InputData_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UpdateFlowEventsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106352, XrefRangeEnd = 1106370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UpdateFlowEventsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1106395, RefRangeEnd = 1106396, XrefRangeStart = 1106370, XrefRangeEnd = 1106395, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateFlowEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateFlowEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1106400, RefRangeEnd = 1106401, XrefRangeStart = 1106396, XrefRangeEnd = 1106400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateFlowEventsSystem()
    {
      Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (UpdateFlowEventsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr);
      UpdateFlowEventsSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, nameof (_Query));
      UpdateFlowEventsSystem.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, nameof (_DestroyBarrier));
      UpdateFlowEventsSystem.NativeFieldInfoPtr__LocalControlledAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, nameof (_LocalControlledAccessor));
      UpdateFlowEventsSystem.NativeFieldInfoPtr___UpdateFlowEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, "<>UpdateFlowEvents_entityQuery");
      UpdateFlowEventsSystem.NativeFieldInfoPtr___UpdateFlowEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, "<>UpdateFlowEvents_profilerMarker");
      UpdateFlowEventsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687627);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687628);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687629);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_ValidatePlaybackSpeed_Private_Static_Boolean_byref_InputData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687630);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_SetPlaybackSpeedRecursive_Private_Static_Void_Int32_byref_InputData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687631);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_StartNodeRecursive_Private_Static_StartResult_byref_EventStruct_Int32_byref_InputData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687632);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_SetStateRecursive_Private_Static_Void_Int32_byref_InputData_EventStateEnum_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687633);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_UpdateNodeRecursive_Private_Static_Boolean_byref_EventStruct_Int32_byref_InputData_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687634);
      UpdateFlowEventsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687635);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687636);
      UpdateFlowEventsSystem.NativeMethodInfoPtr___GetEntityQuery_ForUpdateFlowEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687637);
      UpdateFlowEventsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, 100687638);
    }

    public UpdateFlowEventsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<LocalControlled> _LocalControlledAccessor
    {
      get
      {
        return *(SingletonAccessor<LocalControlled>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr__LocalControlledAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr__LocalControlledAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<LocalControlled>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __UpdateFlowEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr___UpdateFlowEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr___UpdateFlowEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateFlowEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr___UpdateFlowEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.NativeFieldInfoPtr___UpdateFlowEvents_profilerMarker)) = value;
      }
    }

    public enum StartResult
    {
      DidntStart,
      Running,
      StartedAndFinished,
    }

    [ObfuscatedName("ProjectM.Sequencer.UpdateFlowEventsSystem/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_isFlying;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref SequenceInstance sequenceInstance,
        ref DynamicBuffer<EventStateElement> eventStates,
        ref DynamicBuffer<BlackboardElement> blackBoardBuffer,
        [In] ref SequenceAsset sequenceAsset)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackBoardBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr);
        UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
        UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_isFlying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (isFlying));
        UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (currentTime));
        UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (currentFrame));
        UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (deltaTime));
        UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (commandBuffer));
        UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, 100687639);
        UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, 100687640);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass6_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass6_0>.NativeClassPtr, data));
      }

      public unsafe UpdateFlowEventsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UpdateFlowEventsSystem) null : new UpdateFlowEventsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe bool isFlying
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_isFlying));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_isFlying)) = value;
        }
      }

      public unsafe float currentTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_currentTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_currentTime)) = value;
        }
      }

      public unsafe int currentFrame
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_currentFrame));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_currentFrame)) = value;
        }
      }

      public unsafe float deltaTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_deltaTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_deltaTime)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UpdateFlowEventsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.UpdateFlowEventsSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateFlowEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateFlowEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_isFlying;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_deltaTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CustomCulling_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_OcclusionCulling_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_DestroySequenceOnCompletion_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateFlowEventsSystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public bool isFlying;
      [FieldOffset(4)]
      public float currentTime;
      [FieldOffset(8)]
      public int currentFrame;
      [FieldOffset(12)]
      public float deltaTime;
      [FieldOffset(16)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Disabled> _ComponentDataFromEntity_Disabled_0;
      [FieldOffset(64)]
      public ComponentDataFromEntity<CustomCulling> _ComponentDataFromEntity_CustomCulling_1;
      [FieldOffset(96)]
      public ComponentDataFromEntity<OcclusionCulling> _ComponentDataFromEntity_OcclusionCulling_2;
      [FieldOffset(128)]
      public ComponentDataFromEntity<DestroySequenceOnCompletion> _ComponentDataFromEntity_DestroySequenceOnCompletion_3;
      [FieldOffset(160)]
      public UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(312)]
      public unsafe UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106116, XrefRangeEnd = 1106160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref SequenceInstance sequenceInstance,
        ref DynamicBuffer<EventStateElement> eventStates,
        ref DynamicBuffer<BlackboardElement> blackBoardBuffer,
        [In] ref SequenceAsset sequenceAsset)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref eventStates;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref blackBoardBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref sequenceAsset;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1106160, RefRangeEnd = 1106161, XrefRangeStart = 1106160, XrefRangeEnd = 1106160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UpdateFlowEventsSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1106161, RefRangeEnd = 1106162, XrefRangeStart = 1106161, XrefRangeEnd = 1106161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UpdateFlowEventsSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106162, XrefRangeEnd = 1106164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1106179, RefRangeEnd = 1106180, XrefRangeStart = 1106164, XrefRangeEnd = 1106179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1106194, RefRangeEnd = 1106195, XrefRangeStart = 1106180, XrefRangeEnd = 1106194, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UpdateFlowEventsSystem componentSystem,
        ref UpdateFlowEventsSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateFlowEventsSystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106195, XrefRangeEnd = 1106199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106199, XrefRangeEnd = 1106205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateFlowEvents()
      {
        Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateFlowEventsSystem>.NativeClassPtr, "<>c__DisplayClass_UpdateFlowEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr);
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_isFlying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (isFlying));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_currentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (currentTime));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (currentFrame));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_deltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (deltaTime));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (commandBuffer));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr__ComponentDataFromEntity_Disabled_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (_ComponentDataFromEntity_Disabled_0));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr__ComponentDataFromEntity_CustomCulling_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (_ComponentDataFromEntity_CustomCulling_1));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr__ComponentDataFromEntity_OcclusionCulling_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (_ComponentDataFromEntity_OcclusionCulling_2));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr__ComponentDataFromEntity_DestroySequenceOnCompletion_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (_ComponentDataFromEntity_DestroySequenceOnCompletion_3));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (_runtimes));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SequenceInstance_byref_DynamicBuffer_1_EventStateElement_byref_DynamicBuffer_1_BlackboardElement_byref_SequenceAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, 100687641);
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, 100687642);
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, 100687643);
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, 100687644);
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, 100687645);
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateFlowEventsSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, 100687646);
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, 100687647);
        UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, 100687648);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceInstance;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_eventStates;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_blackBoardBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_sequenceAsset;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateFlowEventsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SequenceInstance> forParameter_sequenceInstance;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<EventStateElement> forParameter_eventStates;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement> forParameter_blackBoardBuffer;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_IComponentData<SequenceAsset> forParameter_sequenceAsset;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1106026, RefRangeEnd = 1106027, XrefRangeStart = 1106013, XrefRangeEnd = 1106026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UpdateFlowEventsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateFlowEventsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1106040, RefRangeEnd = 1106041, XrefRangeStart = 1106027, XrefRangeEnd = 1106040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceInstance));
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_eventStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_eventStates));
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_blackBoardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_blackBoardBuffer));
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_sequenceAsset));
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UpdateFlowEventsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, 100687649);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, 100687650);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceInstance;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_eventStates;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_blackBoardBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_sequenceAsset;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SequenceInstance>.Runtime runtime_sequenceInstance;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<EventStateElement>.Runtime runtime_eventStates;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_DynamicBuffer<BlackboardElement>.Runtime runtime_blackBoardBuffer;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<SequenceAsset>.Runtime runtime_sequenceAsset;

          static Runtimes()
          {
            Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceInstance));
            UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_eventStates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_eventStates));
            UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_blackBoardBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_blackBoardBuffer));
            UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_sequenceAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_sequenceAsset));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.UpdateFlowEventsSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateFlowEvents/ProjectM.Sequencer.RunWithoutJobSystem_0000555E$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, "RunWithoutJobSystem_0000555E$PostfixBurstDelegate");
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687651);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687652);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687653);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100687654);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Sequencer.UpdateFlowEventsSystem/ProjectM.Sequencer.<>c__DisplayClass_UpdateFlowEvents/ProjectM.Sequencer.RunWithoutJobSystem_0000555E$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106041, XrefRangeEnd = 1106055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106055, XrefRangeEnd = 1106073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106073, XrefRangeEnd = 1106088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1106115, RefRangeEnd = 1106116, XrefRangeStart = 1106088, XrefRangeEnd = 1106115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents>.NativeClassPtr, "RunWithoutJobSystem_0000555E$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687655);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687656);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687657);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687658);
          UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100687660);
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
            IL2CPP.il2cpp_field_static_get_value(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(UpdateFlowEventsSystem.__c__DisplayClass_UpdateFlowEvents.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
