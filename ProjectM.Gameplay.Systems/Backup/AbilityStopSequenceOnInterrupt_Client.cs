// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityStopSequenceOnInterrupt_Client
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class AbilityStopSequenceOnInterrupt_Client : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SequencesToDestroy;
    private static readonly System.IntPtr NativeFieldInfoPtr___StopSequenceOnInterrupt_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___StopSequenceOnInterrupt_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForStopSequenceOnInterrupt_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367088, XrefRangeEnd = 1367091, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367091, XrefRangeEnd = 1367094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367094, XrefRangeEnd = 1367127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityStopSequenceOnInterrupt_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367127, XrefRangeEnd = 1367160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367160, XrefRangeEnd = 1367176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForStopSequenceOnInterrupt_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr___GetEntityQuery_ForStopSequenceOnInterrupt_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1367180, RefRangeEnd = 1367181, XrefRangeStart = 1367176, XrefRangeEnd = 1367180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityStopSequenceOnInterrupt_Client()
    {
      Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityStopSequenceOnInterrupt_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr);
      AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr__SequencesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, nameof (_SequencesToDestroy));
      AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr___StopSequenceOnInterrupt_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, "<>StopSequenceOnInterrupt_entityQuery");
      AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr___StopSequenceOnInterrupt_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, "<>StopSequenceOnInterrupt_profilerMarker");
      AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, 100664021);
      AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, 100664022);
      AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, 100664023);
      AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, 100664024);
      AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, 100664025);
      AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr___GetEntityQuery_ForStopSequenceOnInterrupt_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, 100664026);
      AbilityStopSequenceOnInterrupt_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, 100664027);
    }

    public AbilityStopSequenceOnInterrupt_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<SequenceState> _SequencesToDestroy
    {
      get
      {
        return *(NativeList<SequenceState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr__SequencesToDestroy));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr__SequencesToDestroy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SequenceState>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __StopSequenceOnInterrupt_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr___StopSequenceOnInterrupt_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr___StopSequenceOnInterrupt_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __StopSequenceOnInterrupt_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr___StopSequenceOnInterrupt_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.NativeFieldInfoPtr___StopSequenceOnInterrupt_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AbilityStopSequenceOnInterrupt_Client/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_sequencesToDestroy;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityInterruptedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref AbilityInterruptedEvent interruptedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref interruptedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityInterruptedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr, nameof (entityManager));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr_sequencesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr, nameof (sequencesToDestroy));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr, 100664028);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityInterruptedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr, 100664029);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe AbilityStopSequenceOnInterrupt_Client __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AbilityStopSequenceOnInterrupt_Client) null : new AbilityStopSequenceOnInterrupt_Client(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeList<SequenceState> sequencesToDestroy
      {
        get
        {
          return *(NativeList<SequenceState>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr_sequencesToDestroy));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0.NativeFieldInfoPtr_sequencesToDestroy), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<SequenceState>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityStopSequenceOnInterrupt_Client/ProjectM.<>c__DisplayClass_StopSequenceOnInterrupt")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_StopSequenceOnInterrupt
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_sequencesToDestroy;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SequenceInstance_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Client_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityInterruptedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStopSequenceOnInterrupt_Client_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public NativeList<SequenceState> sequencesToDestroy;
      [FieldOffset(24)]
      public ComponentDataFromEntity<SequenceInstance> _ComponentDataFromEntity_SequenceInstance_0;
      [FieldOffset(56)]
      public ComponentDataFromEntity<AbilityBar_Client> _ComponentDataFromEntity_AbilityBar_Client_1;
      [FieldOffset(88)]
      public AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367046, XrefRangeEnd = 1367061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityInterruptedEvent interruptedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref interruptedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityInterruptedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1203530, RefRangeEnd = 1203532, XrefRangeStart = 1203530, XrefRangeEnd = 1203532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1203532, RefRangeEnd = 1203534, XrefRangeStart = 1203532, XrefRangeEnd = 1203534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367061, XrefRangeEnd = 1367063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367068, RefRangeEnd = 1367069, XrefRangeStart = 1367063, XrefRangeEnd = 1367068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367077, RefRangeEnd = 1367078, XrefRangeStart = 1367069, XrefRangeEnd = 1367077, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityStopSequenceOnInterrupt_Client componentSystem,
        ref AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStopSequenceOnInterrupt_Client_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367078, XrefRangeEnd = 1367082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367082, XrefRangeEnd = 1367088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_StopSequenceOnInterrupt()
      {
        Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client>.NativeClassPtr, "<>c__DisplayClass_StopSequenceOnInterrupt");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (entityManager));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr_sequencesToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (sequencesToDestroy));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr__ComponentDataFromEntity_SequenceInstance_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (_ComponentDataFromEntity_SequenceInstance_0));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr__ComponentDataFromEntity_AbilityBar_Client_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (_ComponentDataFromEntity_AbilityBar_Client_1));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (_runtimes));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityInterruptedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, 100664030);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, 100664031);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, 100664032);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, 100664033);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, 100664034);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStopSequenceOnInterrupt_Client_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, 100664035);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, 100664036);
        AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, 100664037);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interruptedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStopSequenceOnInterrupt_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityInterruptedEvent> forParameter_interruptedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1366966, RefRangeEnd = 1366967, XrefRangeStart = 1366963, XrefRangeEnd = 1366966, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityStopSequenceOnInterrupt_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStopSequenceOnInterrupt_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1366970, RefRangeEnd = 1366971, XrefRangeStart = 1366967, XrefRangeEnd = 1366970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interruptedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interruptedEvent));
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityStopSequenceOnInterrupt_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders>.NativeClassPtr, 100664038);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders>.NativeClassPtr, 100664039);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interruptedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityInterruptedEvent>.Runtime runtime_interruptedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interruptedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interruptedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityStopSequenceOnInterrupt_Client/ProjectM.<>c__DisplayClass_StopSequenceOnInterrupt/ProjectM.RunWithoutJobSystem_0000019F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, "RunWithoutJobSystem_0000019F$PostfixBurstDelegate");
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664040);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664041);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664042);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664043);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityStopSequenceOnInterrupt_Client/ProjectM.<>c__DisplayClass_StopSequenceOnInterrupt/ProjectM.RunWithoutJobSystem_0000019F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366971, XrefRangeEnd = 1366985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1366985, XrefRangeEnd = 1367003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367003, XrefRangeEnd = 1367018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1367045, RefRangeEnd = 1367046, XrefRangeStart = 1367018, XrefRangeEnd = 1367045, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt>.NativeClassPtr, "RunWithoutJobSystem_0000019F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664044);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664045);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664046);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664047);
          AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664049);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityStopSequenceOnInterrupt_Client.__c__DisplayClass_StopSequenceOnInterrupt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
