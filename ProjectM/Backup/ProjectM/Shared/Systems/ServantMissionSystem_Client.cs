// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Systems.ServantMissionSystem_Client
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Shared.Systems
{
  public class ServantMissionSystem_Client : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantMissionSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__MissionStartedEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_FINISH_EVENT_HANDLE_FREQUENCY;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastFinishEventHandleTime;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleServantMissionFinishedEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleServantMissionFinishedEvents_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleServantMissionStartedEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleServantMissionStartedEvents_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionFinishedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionStartedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121233, XrefRangeEnd = 1121252, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121252, XrefRangeEnd = 1121291, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121291, XrefRangeEnd = 1121292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantMissionSystem_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121292, XrefRangeEnd = 1121348, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantMissionSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121348, XrefRangeEnd = 1121364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleServantMissionFinishedEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionFinishedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121364, XrefRangeEnd = 1121380, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleServantMissionStartedEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionStartedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServantMissionSystem_Client()
    {
      Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared.Systems", nameof (ServantMissionSystem_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr);
      ServantMissionSystem_Client.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, nameof (_GameDataSystem));
      ServantMissionSystem_Client.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, nameof (_NetworkIdSystem));
      ServantMissionSystem_Client.NativeFieldInfoPtr__PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, nameof (_PostUpdateBarrier));
      ServantMissionSystem_Client.NativeFieldInfoPtr__ServantMissionSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, nameof (_ServantMissionSettingsAccessor));
      ServantMissionSystem_Client.NativeFieldInfoPtr__MissionStartedEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, nameof (_MissionStartedEventQuery));
      ServantMissionSystem_Client.NativeFieldInfoPtr_MAX_FINISH_EVENT_HANDLE_FREQUENCY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, nameof (MAX_FINISH_EVENT_HANDLE_FREQUENCY));
      ServantMissionSystem_Client.NativeFieldInfoPtr__LastFinishEventHandleTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, nameof (_LastFinishEventHandleTime));
      ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionFinishedEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, "<>HandleServantMissionFinishedEvents_entityQuery");
      ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionFinishedEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, "<>HandleServantMissionFinishedEvents_profilerMarker");
      ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionStartedEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, "<>HandleServantMissionStartedEvents_entityQuery");
      ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionStartedEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, "<>HandleServantMissionStartedEvents_profilerMarker");
      ServantMissionSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, 100688947);
      ServantMissionSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, 100688948);
      ServantMissionSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, 100688949);
      ServantMissionSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, 100688950);
      ServantMissionSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionFinishedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, 100688951);
      ServantMissionSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleServantMissionStartedEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, 100688952);
    }

    public ServantMissionSystem_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PostUpdateBarrier _PostUpdateBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__PostUpdateBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__PostUpdateBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServantMissionSettingsSingleton> _ServantMissionSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServantMissionSettingsSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__ServantMissionSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__ServantMissionSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServantMissionSettingsSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery _MissionStartedEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__MissionStartedEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__MissionStartedEventQuery)) = value;
      }
    }

    public static unsafe float MAX_FINISH_EVENT_HANDLE_FREQUENCY
    {
      get
      {
        float eventHandleFrequency;
        IL2CPP.il2cpp_field_static_get_value(ServantMissionSystem_Client.NativeFieldInfoPtr_MAX_FINISH_EVENT_HANDLE_FREQUENCY, (void*) &eventHandleFrequency);
        return eventHandleFrequency;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ServantMissionSystem_Client.NativeFieldInfoPtr_MAX_FINISH_EVENT_HANDLE_FREQUENCY, (void*) &value);
      }
    }

    public unsafe double _LastFinishEventHandleTime
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__LastFinishEventHandleTime));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr__LastFinishEventHandleTime)) = value;
      }
    }

    public unsafe EntityQuery __HandleServantMissionFinishedEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionFinishedEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionFinishedEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleServantMissionFinishedEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionFinishedEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionFinishedEvents_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __HandleServantMissionStartedEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionStartedEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionStartedEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleServantMissionStartedEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionStartedEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.NativeFieldInfoPtr___HandleServantMissionStartedEvents_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionSystem_Client/<>c__DisplayClass8_0")]
    public sealed class __c__DisplayClass8_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ServantMissionFinishedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_Entity_byref_ServantMissionStartedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass8_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref ServantMissionFinishedEvent evt)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ServantMissionFinishedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1([In] ref Entity entity, [In] ref ServantMissionStartedEvent evt)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_Entity_byref_ServantMissionStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass8_0()
      {
        Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, "<>c__DisplayClass8_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr);
        ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
        ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_servantMissionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, nameof (servantMissionSettings));
        ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ServantMissionSystem_Client.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, 100688953);
        ServantMissionSystem_Client.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ServantMissionFinishedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, 100688954);
        ServantMissionSystem_Client.__c__DisplayClass8_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_Entity_byref_ServantMissionStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, 100688955);
      }

      public __c__DisplayClass8_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass8_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass8_0>.NativeClassPtr, data));
      }

      public unsafe ServantMissionSystem_Client __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantMissionSystem_Client) null : new ServantMissionSystem_Client(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServantMissionSettingsSingleton servantMissionSettings
      {
        get
        {
          return *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_servantMissionSettings));
        }
        [param: In] set
        {
          *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_servantMissionSettings)) = value;
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass8_0.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionSystem_Client/ProjectM.Shared.Systems.<>c__DisplayClass_HandleServantMissionFinishedEvents")]
    public sealed class __c__DisplayClass_HandleServantMissionFinishedEvents : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ServantCoffinstation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ServantMissionFinishedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121160, RefRangeEnd = 1121161, XrefRangeStart = 1121132, XrefRangeEnd = 1121160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref ServantMissionFinishedEvent evt)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ServantMissionFinishedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121162, RefRangeEnd = 1121163, XrefRangeStart = 1121161, XrefRangeEnd = 1121162, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServantMissionSystem_Client.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121164, RefRangeEnd = 1121165, XrefRangeStart = 1121163, XrefRangeEnd = 1121164, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServantMissionSystem_Client.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121165, XrefRangeEnd = 1121167, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121173, RefRangeEnd = 1121174, XrefRangeStart = 1121167, XrefRangeEnd = 1121173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121179, RefRangeEnd = 1121180, XrefRangeStart = 1121174, XrefRangeEnd = 1121179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServantMissionSystem_Client componentSystem,
        ref ServantMissionSystem_Client.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121180, XrefRangeEnd = 1121186, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleServantMissionFinishedEvents()
      {
        Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, "<>c__DisplayClass_HandleServantMissionFinishedEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, "<>4__this");
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, nameof (networkIdToEntityMap));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_servantMissionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, nameof (servantMissionSettings));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__ComponentDataFromEntity_ServantCoffinstation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, nameof (_ComponentDataFromEntity_ServantCoffinstation_0));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, nameof (_runtimes));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ServantMissionFinishedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, 100688956);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, 100688957);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, 100688958);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, 100688959);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, 100688960);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, 100688961);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, 100688962);
      }

      public __c__DisplayClass_HandleServantMissionFinishedEvents(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_HandleServantMissionFinishedEvents()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, data));
      }

      public unsafe ServantMissionSystem_Client __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantMissionSystem_Client) null : new ServantMissionSystem_Client(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServantMissionSettingsSingleton servantMissionSettings
      {
        get
        {
          return *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_servantMissionSettings));
        }
        [param: In] set
        {
          *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_servantMissionSettings)) = value;
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }

      public unsafe ComponentDataFromEntity<ServantCoffinstation> _ComponentDataFromEntity_ServantCoffinstation_0
      {
        get
        {
          return *(ComponentDataFromEntity<ServantCoffinstation>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__ComponentDataFromEntity_ServantCoffinstation_0));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__ComponentDataFromEntity_ServantCoffinstation_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<ServantCoffinstation>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ServantMissionFinishedEvent> forParameter_evt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1121126, RefRangeEnd = 1121127, XrefRangeStart = 1121122, XrefRangeEnd = 1121126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantMissionSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1121131, RefRangeEnd = 1121132, XrefRangeStart = 1121127, XrefRangeEnd = 1121131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders>.NativeClassPtr, 100688963);
          ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders>.NativeClassPtr, 100688964);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ServantMissionFinishedEvent>.Runtime runtime_evt;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionFinishedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServantMissionSystem_Client/ProjectM.Shared.Systems.<>c__DisplayClass_HandleServantMissionStartedEvents")]
    public sealed class __c__DisplayClass_HandleServantMissionStartedEvents : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_servantMissionSettings;
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_ServantMissionStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_byref___c__DisplayClass8_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121210, RefRangeEnd = 1121211, XrefRangeStart = 1121196, XrefRangeEnd = 1121210, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref Entity entity, [In] ref ServantMissionStartedEvent evt)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_ServantMissionStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121212, RefRangeEnd = 1121213, XrefRangeStart = 1121211, XrefRangeEnd = 1121212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServantMissionSystem_Client.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121214, RefRangeEnd = 1121215, XrefRangeStart = 1121213, XrefRangeEnd = 1121214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServantMissionSystem_Client.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121215, XrefRangeEnd = 1121217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121223, RefRangeEnd = 1121224, XrefRangeStart = 1121217, XrefRangeEnd = 1121223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121226, RefRangeEnd = 1121227, XrefRangeStart = 1121224, XrefRangeEnd = 1121226, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServantMissionSystem_Client componentSystem,
        ref ServantMissionSystem_Client.__c__DisplayClass8_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_byref___c__DisplayClass8_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121227, XrefRangeEnd = 1121233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleServantMissionStartedEvents()
      {
        Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSystem_Client>.NativeClassPtr, "<>c__DisplayClass_HandleServantMissionStartedEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, "<>4__this");
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_servantMissionSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (servantMissionSettings));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (_runtimes));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_Entity_byref_ServantMissionStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688965);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688966);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688967);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688968);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688969);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_byref___c__DisplayClass8_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688970);
        ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, 100688971);
      }

      public __c__DisplayClass_HandleServantMissionStartedEvents(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_HandleServantMissionStartedEvents()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, data));
      }

      public unsafe ServantMissionSystem_Client __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ServantMissionSystem_Client) null : new ServantMissionSystem_Client(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ServantMissionSettingsSingleton servantMissionSettings
      {
        get
        {
          return *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_servantMissionSettings));
        }
        [param: In] set
        {
          *(ServantMissionSettingsSingleton*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_servantMissionSettings)) = value;
        }
      }

      public unsafe EntityCommandBuffer postUpdateCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_postUpdateCommandBuffer)) = value;
        }
      }

      public unsafe ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ServantMissionStartedEvent> forParameter_evt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1121190, RefRangeEnd = 1121191, XrefRangeStart = 1121186, XrefRangeEnd = 1121190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServantMissionSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1121195, RefRangeEnd = 1121196, XrefRangeStart = 1121191, XrefRangeEnd = 1121195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServantMissionSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, 100688972);
          ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, 100688973);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ServantMissionStartedEvent>.Runtime runtime_evt;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServantMissionSystem_Client.__c__DisplayClass_HandleServantMissionStartedEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
