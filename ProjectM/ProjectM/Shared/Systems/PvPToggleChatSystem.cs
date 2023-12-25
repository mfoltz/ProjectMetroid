// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Systems.PvPToggleChatSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Shared.Systems
{
  public class PvPToggleChatSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ToggleEventsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__RandomLocalizationKeys;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleServantMissionStartedEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleServantMissionStartedEvents_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionStartedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119742, XrefRangeEnd = 1119754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PvPToggleChatSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119754, XrefRangeEnd = 1119771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PvPToggleChatSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PvPToggleChatSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119771, XrefRangeEnd = 1119800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PvPToggleChatSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119800, XrefRangeEnd = 1119816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleServantMissionStartedEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionStartedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static PvPToggleChatSystem()
    {
      Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared.Systems", nameof (PvPToggleChatSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr);
      PvPToggleChatSystem.NativeFieldInfoPtr__ToggleEventsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, nameof (_ToggleEventsQuery));
      PvPToggleChatSystem.NativeFieldInfoPtr__PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, nameof (_PostUpdateBarrier));
      PvPToggleChatSystem.NativeFieldInfoPtr__RandomLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, nameof (_RandomLocalizationKeys));
      PvPToggleChatSystem.NativeFieldInfoPtr___HandleServantMissionStartedEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, "<>HandleServantMissionStartedEvents_entityQuery");
      PvPToggleChatSystem.NativeFieldInfoPtr___HandleServantMissionStartedEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, "<>HandleServantMissionStartedEvents_profilerMarker");
      PvPToggleChatSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, 100688833);
      PvPToggleChatSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, 100688834);
      PvPToggleChatSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, 100688835);
      PvPToggleChatSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, 100688836);
      PvPToggleChatSystem.NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionStartedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, 100688837);
    }

    public PvPToggleChatSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _ToggleEventsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr__ToggleEventsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr__ToggleEventsQuery)) = value;
      }
    }

    public unsafe PostUpdateBarrier _PostUpdateBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr__PostUpdateBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr__PostUpdateBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe RandomLocalizationKeys _RandomLocalizationKeys
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr__RandomLocalizationKeys));
        return pointer == System.IntPtr.Zero ? (RandomLocalizationKeys) null : new RandomLocalizationKeys(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr__RandomLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __HandleServantMissionStartedEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr___HandleServantMissionStartedEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr___HandleServantMissionStartedEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleServantMissionStartedEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr___HandleServantMissionStartedEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.NativeFieldInfoPtr___HandleServantMissionStartedEvents_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.PvPToggleChatSystem/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_randomLocalizationKeys;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Entity_byref_PvPToggleEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref Entity entity, [In] ref PvPToggleEvent evt)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Entity_byref_PvPToggleEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr);
        PvPToggleChatSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_randomLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (randomLocalizationKeys));
        PvPToggleChatSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        PvPToggleChatSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr, 100688838);
        PvPToggleChatSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_Entity_byref_PvPToggleEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr, 100688839);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass4_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass4_0>.NativeClassPtr, data));
      }

      public unsafe RandomLocalizationKeys randomLocalizationKeys
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_randomLocalizationKeys));
          return pointer == System.IntPtr.Zero ? (RandomLocalizationKeys) null : new RandomLocalizationKeys(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_randomLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.PvPToggleChatSystem/ProjectM.Shared.Systems.<>c__DisplayClass_HandleServantMissionStartedEvents")]
    public sealed class __c__DisplayClass_HandleServantMissionStartedEvents : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_randomLocalizationKeys;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_PvPToggleEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PvPToggleChatSystem_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119723, RefRangeEnd = 1119724, XrefRangeStart = 1119717, XrefRangeEnd = 1119723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref Entity entity, [In] ref PvPToggleEvent evt)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_PvPToggleEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(6)]
      [CachedScanResults(RefRangeStart = 996504, RefRangeEnd = 996510, XrefRangeStart = 996504, XrefRangeEnd = 996510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref PvPToggleChatSystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 996511, RefRangeEnd = 996523, XrefRangeStart = 996511, XrefRangeEnd = 996523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref PvPToggleChatSystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119724, XrefRangeEnd = 1119726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119732, RefRangeEnd = 1119733, XrefRangeStart = 1119726, XrefRangeEnd = 1119732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1119735, RefRangeEnd = 1119736, XrefRangeStart = 1119733, XrefRangeEnd = 1119735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        PvPToggleChatSystem componentSystem,
        ref PvPToggleChatSystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PvPToggleChatSystem_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1119736, XrefRangeEnd = 1119742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleServantMissionStartedEvents()
      {
        Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PvPToggleChatSystem>.NativeClassPtr, "<>c__DisplayClass_HandleServantMissionStartedEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr);
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_randomLocalizationKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (randomLocalizationKeys));
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (_runtimes));
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_PvPToggleEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688840);
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688841);
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688842);
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688843);
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688844);
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PvPToggleChatSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688845);
        PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688846);
      }

      public __c__DisplayClass_HandleServantMissionStartedEvents(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_HandleServantMissionStartedEvents()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, data));
      }

      public unsafe RandomLocalizationKeys randomLocalizationKeys
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_randomLocalizationKeys));
          return pointer == System.IntPtr.Zero ? (RandomLocalizationKeys) null : new RandomLocalizationKeys(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_randomLocalizationKeys), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }

      public unsafe PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PvPToggleChatSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<PvPToggleEvent> forParameter_evt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119711, RefRangeEnd = 1119712, XrefRangeStart = 1119707, XrefRangeEnd = 1119711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(PvPToggleChatSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PvPToggleChatSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1119716, RefRangeEnd = 1119717, XrefRangeStart = 1119712, XrefRangeEnd = 1119716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_PvPToggleChatSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, 100688847);
          PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, 100688848);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<PvPToggleEvent>.Runtime runtime_evt;

          static Runtimes()
          {
            Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PvPToggleChatSystem.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
