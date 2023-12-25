// Decompiled with JetBrains decompiler
// Type: ProjectM.AutoChainTransitionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;

#nullable disable
namespace ProjectM
{
  public class AutoChainTransitionSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnChainDebugEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventsWrittenPerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxEventsTriggeredPerFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryProgressAutoChainTransitionTarget_Public_Static_Boolean_Int32_SpawnChainConstants_byref_SpawnChainInstance_Boolean_Boolean_Double_byref_Int32_byref_Int32_byref_TransitionId_byref_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069207, XrefRangeEnd = 1069223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AutoChainTransitionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069223, XrefRangeEnd = 1069232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AutoChainTransitionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069232, XrefRangeEnd = 1069255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AutoChainTransitionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1069274, RefRangeEnd = 1069276, XrefRangeStart = 1069255, XrefRangeEnd = 1069274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryProgressAutoChainTransitionTarget(
      int currentIndex,
      SpawnChainData.SpawnChainConstants chainConstants,
      [In] ref SpawnChainData.SpawnChainInstance chainInstance,
      bool stopAtMainElement,
      bool skipNextLifetime,
      double surplusLifeTime,
      out int transitionFromElementIndex,
      out int resultingTargetElementIndex,
      out SpawnChainData.TransitionId transitionWithId,
      out double durationToPassForward)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[10];
      numPtr[0] = (System.IntPtr) &currentIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chainConstants;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref chainInstance;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stopAtMainElement;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &skipNextLifetime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &surplusLifeTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) ref transitionFromElementIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) ref resultingTargetElementIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = (System.IntPtr) ref transitionWithId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(9) * sizeof (System.IntPtr))) = (System.IntPtr) ref durationToPassForward;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.NativeMethodInfoPtr_TryProgressAutoChainTransitionTarget_Public_Static_Boolean_Int32_SpawnChainConstants_byref_SpawnChainInstance_Boolean_Boolean_Double_byref_Int32_byref_Int32_byref_TransitionId_byref_Double_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AutoChainTransitionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069276, XrefRangeEnd = 1069278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AutoChainTransitionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1069309, RefRangeEnd = 1069310, XrefRangeStart = 1069278, XrefRangeEnd = 1069309, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AutoChainTransitionSystem()
    {
      Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AutoChainTransitionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr);
      AutoChainTransitionSystem.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, nameof (_SpawnBarrier));
      AutoChainTransitionSystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, nameof (_ServerTime));
      AutoChainTransitionSystem.NativeFieldInfoPtr__SpawnChainDebugEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, nameof (_SpawnChainDebugEnabled));
      AutoChainTransitionSystem.NativeFieldInfoPtr__EventsWrittenPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, nameof (_EventsWrittenPerFrame));
      AutoChainTransitionSystem.NativeFieldInfoPtr_MaxEventsTriggeredPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, nameof (MaxEventsTriggeredPerFrame));
      AutoChainTransitionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      AutoChainTransitionSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, 100684172);
      AutoChainTransitionSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, 100684173);
      AutoChainTransitionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, 100684174);
      AutoChainTransitionSystem.NativeMethodInfoPtr_TryProgressAutoChainTransitionTarget_Public_Static_Boolean_Int32_SpawnChainConstants_byref_SpawnChainInstance_Boolean_Boolean_Double_byref_Int32_byref_Int32_byref_TransitionId_byref_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, 100684175);
      AutoChainTransitionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, 100684176);
      AutoChainTransitionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, 100684177);
      AutoChainTransitionSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, 100684178);
    }

    public AutoChainTransitionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<SpawnChainDebugEnabled> _SpawnChainDebugEnabled
    {
      get
      {
        return *(SingletonAccessor<SpawnChainDebugEnabled>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr__SpawnChainDebugEnabled));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr__SpawnChainDebugEnabled), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<SpawnChainDebugEnabled>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeReference<int> _EventsWrittenPerFrame
    {
      get
      {
        return *(NativeReference<int>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr__EventsWrittenPerFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr__EventsWrittenPerFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeReference<int>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public static unsafe int MaxEventsTriggeredPerFrame
    {
      get
      {
        int triggeredPerFrame;
        IL2CPP.il2cpp_field_static_get_value(AutoChainTransitionSystem.NativeFieldInfoPtr_MaxEventsTriggeredPerFrame, (void*) &triggeredPerFrame);
        return triggeredPerFrame;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(AutoChainTransitionSystem.NativeFieldInfoPtr_MaxEventsTriggeredPerFrame, (void*) &value);
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoChainTransitionSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AutoChainTransitionSystem/<>c__DisplayClass7_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass7_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverElapsedSeconds;
      private static readonly System.IntPtr NativeFieldInfoPtr_eventsWrittenPerFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnChainDebugEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AutoChainInstanceData_byref_SpawnChainConstants_byref_SpawnChainInstance_byref_ActiveChildElement_0;
      [FieldOffset(0)]
      public double serverElapsedSeconds;
      [FieldOffset(8)]
      public NativeReference<int> eventsWrittenPerFrame;
      [FieldOffset(24)]
      public bool spawnChainDebugEnabled;
      [FieldOffset(32)]
      public EntityCommandBuffer commandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref AutoChainInstanceData instance,
        [In] ref SpawnChainData.SpawnChainConstants chainConstants,
        [In] ref SpawnChainData.SpawnChainInstance chainInstance,
        [In] ref SpawnChainData.ActiveChildElement activeChildElement)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref instance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref chainConstants;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref chainInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeChildElement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AutoChainInstanceData_byref_SpawnChainConstants_byref_SpawnChainInstance_byref_ActiveChildElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr);
        AutoChainTransitionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_serverElapsedSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (serverElapsedSeconds));
        AutoChainTransitionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_eventsWrittenPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (eventsWrittenPerFrame));
        AutoChainTransitionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_spawnChainDebugEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (spawnChainDebugEnabled));
        AutoChainTransitionSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (commandBuffer));
        AutoChainTransitionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr, 100684179);
        AutoChainTransitionSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AutoChainInstanceData_byref_SpawnChainConstants_byref_SpawnChainInstance_byref_ActiveChildElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr, 100684180);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass7_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.AutoChainTransitionSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_serverElapsedSeconds;
      private static readonly System.IntPtr NativeFieldInfoPtr_eventsWrittenPerFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnChainDebugEnabled;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AutoChainInstanceData_byref_SpawnChainConstants_byref_SpawnChainInstance_byref_ActiveChildElement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AutoChainTransitionSystem_byref___c__DisplayClass7_0_0;
      [FieldOffset(0)]
      public double serverElapsedSeconds;
      [FieldOffset(8)]
      public NativeReference<int> eventsWrittenPerFrame;
      [FieldOffset(24)]
      public bool spawnChainDebugEnabled;
      [FieldOffset(32)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(48)]
      public AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(184)]
      public unsafe AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069119, XrefRangeEnd = 1069185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref AutoChainInstanceData instance,
        [In] ref SpawnChainData.SpawnChainConstants chainConstants,
        [In] ref SpawnChainData.SpawnChainInstance chainInstance,
        [In] ref SpawnChainData.ActiveChildElement activeChildElement)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref instance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref chainConstants;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref chainInstance;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref activeChildElement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AutoChainInstanceData_byref_SpawnChainConstants_byref_SpawnChainInstance_byref_ActiveChildElement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069185, RefRangeEnd = 1069186, XrefRangeStart = 1069185, XrefRangeEnd = 1069185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AutoChainTransitionSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1069186, XrefRangeEnd = 1069188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069203, RefRangeEnd = 1069204, XrefRangeStart = 1069188, XrefRangeEnd = 1069203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1069206, RefRangeEnd = 1069207, XrefRangeStart = 1069204, XrefRangeEnd = 1069206, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AutoChainTransitionSystem componentSystem,
        ref AutoChainTransitionSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AutoChainTransitionSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AutoChainTransitionSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_serverElapsedSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (serverElapsedSeconds));
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_eventsWrittenPerFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (eventsWrittenPerFrame));
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_spawnChainDebugEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (spawnChainDebugEnabled));
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (commandBuffer));
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AutoChainInstanceData_byref_SpawnChainConstants_byref_SpawnChainInstance_byref_ActiveChildElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100684181);
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100684182);
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100684183);
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100684184);
        AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AutoChainTransitionSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100684185);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_instance;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chainConstants;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_chainInstance;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeChildElement;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AutoChainTransitionSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AutoChainInstanceData> forParameter_instance;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainData.SpawnChainConstants> forParameter_chainConstants;
        [FieldOffset(72)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainData.SpawnChainInstance> forParameter_chainInstance;
        [FieldOffset(104)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainData.ActiveChildElement> forParameter_activeChildElement;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069104, RefRangeEnd = 1069105, XrefRangeStart = 1069091, XrefRangeEnd = 1069104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AutoChainTransitionSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AutoChainTransitionSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1069118, RefRangeEnd = 1069119, XrefRangeStart = 1069105, XrefRangeEnd = 1069118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_instance));
          AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chainConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chainConstants));
          AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_chainInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_chainInstance));
          AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeChildElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeChildElement));
          AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AutoChainTransitionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100684186);
          AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100684187);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_instance;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chainConstants;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_chainInstance;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeChildElement;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AutoChainInstanceData>.Runtime runtime_instance;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainData.SpawnChainConstants>.Runtime runtime_chainConstants;
          [FieldOffset(24)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainData.SpawnChainInstance>.Runtime runtime_chainInstance;
          [FieldOffset(32)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainData.ActiveChildElement>.Runtime runtime_activeChildElement;

          static Runtimes()
          {
            Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_instance));
            AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chainConstants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chainConstants));
            AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_chainInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_chainInstance));
            AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeChildElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeChildElement));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AutoChainTransitionSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
