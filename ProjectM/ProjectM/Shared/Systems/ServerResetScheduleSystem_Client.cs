// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.Systems.ServerResetScheduleSystem_Client
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
  public class ServerResetScheduleSystem_Client : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ScheduleNotificationEventsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerResetScheduleNoticeSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleResetScheduleNotificationEvents_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___HandleResetScheduleNotificationEvents_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForHandleResetScheduleNotificationEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121426, XrefRangeEnd = 1121435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerResetScheduleSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121435, XrefRangeEnd = 1121457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerResetScheduleSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerResetScheduleSystem_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121457, XrefRangeEnd = 1121486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServerResetScheduleSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121486, XrefRangeEnd = 1121502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForHandleResetScheduleNotificationEvents_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleResetScheduleNotificationEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ServerResetScheduleSystem_Client()
    {
      Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Shared.Systems", nameof (ServerResetScheduleSystem_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr);
      ServerResetScheduleSystem_Client.NativeFieldInfoPtr__PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, nameof (_PostUpdateBarrier));
      ServerResetScheduleSystem_Client.NativeFieldInfoPtr__ScheduleNotificationEventsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, nameof (_ScheduleNotificationEventsQuery));
      ServerResetScheduleSystem_Client.NativeFieldInfoPtr__ServerResetScheduleNoticeSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, nameof (_ServerResetScheduleNoticeSettingsAccessor));
      ServerResetScheduleSystem_Client.NativeFieldInfoPtr___HandleResetScheduleNotificationEvents_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, "<>HandleResetScheduleNotificationEvents_entityQuery");
      ServerResetScheduleSystem_Client.NativeFieldInfoPtr___HandleResetScheduleNotificationEvents_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, "<>HandleResetScheduleNotificationEvents_profilerMarker");
      ServerResetScheduleSystem_Client.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, 100688974);
      ServerResetScheduleSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, 100688975);
      ServerResetScheduleSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, 100688976);
      ServerResetScheduleSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, 100688977);
      ServerResetScheduleSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForHandleResetScheduleNotificationEvents_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, 100688978);
    }

    public ServerResetScheduleSystem_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PostUpdateBarrier _PostUpdateBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr__PostUpdateBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr__PostUpdateBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _ScheduleNotificationEventsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr__ScheduleNotificationEventsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr__ScheduleNotificationEventsQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerResetScheduleNoticeSettingsSingleton> _ServerResetScheduleNoticeSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerResetScheduleNoticeSettingsSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr__ServerResetScheduleNoticeSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr__ServerResetScheduleNoticeSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerResetScheduleNoticeSettingsSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __HandleResetScheduleNotificationEvents_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr___HandleResetScheduleNotificationEvents_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr___HandleResetScheduleNotificationEvents_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __HandleResetScheduleNotificationEvents_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr___HandleResetScheduleNotificationEvents_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServerResetScheduleSystem_Client.NativeFieldInfoPtr___HandleResetScheduleNotificationEvents_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServerResetScheduleSystem_Client/<>c__DisplayClass4_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass4_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_settings;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ResetScheduleNotificationEvent_0;
      [FieldOffset(0)]
      public EntityCommandBuffer postUpdateCommandBuffer;
      [FieldOffset(16)]
      public ServerResetScheduleNoticeSettingsSingleton settings;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref ResetScheduleNotificationEvent evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ResetScheduleNotificationEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass4_0>.NativeClassPtr);
        ServerResetScheduleSystem_Client.__c__DisplayClass4_0.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass4_0>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ServerResetScheduleSystem_Client.__c__DisplayClass4_0.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass4_0>.NativeClassPtr, nameof (settings));
        ServerResetScheduleSystem_Client.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass4_0>.NativeClassPtr, 100688979);
        ServerResetScheduleSystem_Client.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ResetScheduleNotificationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass4_0>.NativeClassPtr, 100688980);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass4_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Shared.Systems.ServerResetScheduleSystem_Client/ProjectM.Shared.Systems.<>c__DisplayClass_HandleResetScheduleNotificationEvents")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_HandleResetScheduleNotificationEvents
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_postUpdateCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_settings;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ResetScheduleNotificationEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerResetScheduleSystem_Client_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      [FieldOffset(0)]
      public EntityCommandBuffer postUpdateCommandBuffer;
      [FieldOffset(16)]
      public ServerResetScheduleNoticeSettingsSingleton settings;
      [FieldOffset(64)]
      public ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121401, RefRangeEnd = 1121402, XrefRangeStart = 1121390, XrefRangeEnd = 1121401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref ResetScheduleNotificationEvent evt)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref evt;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ResetScheduleNotificationEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1121402, RefRangeEnd = 1121405, XrefRangeStart = 1121402, XrefRangeEnd = 1121402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ServerResetScheduleSystem_Client.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1121405, RefRangeEnd = 1121408, XrefRangeStart = 1121405, XrefRangeEnd = 1121405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ServerResetScheduleSystem_Client.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121408, XrefRangeEnd = 1121410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121416, RefRangeEnd = 1121417, XrefRangeStart = 1121410, XrefRangeEnd = 1121416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1121419, RefRangeEnd = 1121420, XrefRangeStart = 1121417, XrefRangeEnd = 1121419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ServerResetScheduleSystem_Client componentSystem,
        ref ServerResetScheduleSystem_Client.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerResetScheduleSystem_Client_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1121420, XrefRangeEnd = 1121426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_HandleResetScheduleNotificationEvents()
      {
        Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerResetScheduleSystem_Client>.NativeClassPtr, "<>c__DisplayClass_HandleResetScheduleNotificationEvents");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr);
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeFieldInfoPtr_postUpdateCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, nameof (postUpdateCommandBuffer));
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeFieldInfoPtr_settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, nameof (settings));
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, nameof (_runtimes));
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ResetScheduleNotificationEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, 100688981);
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, 100688982);
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, 100688983);
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, 100688984);
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, 100688985);
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerResetScheduleSystem_Client_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, 100688986);
        ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, 100688987);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_evt;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerResetScheduleSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ResetScheduleNotificationEvent> forParameter_evt;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1121384, RefRangeEnd = 1121385, XrefRangeStart = 1121380, XrefRangeEnd = 1121384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ServerResetScheduleSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerResetScheduleSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1121389, RefRangeEnd = 1121390, XrefRangeStart = 1121385, XrefRangeEnd = 1121389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_evt));
          ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ServerResetScheduleSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders>.NativeClassPtr, 100688988);
          ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders>.NativeClassPtr, 100688989);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_evt;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ResetScheduleNotificationEvent>.Runtime runtime_evt;

          static Runtimes()
          {
            Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_evt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_evt));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ServerResetScheduleSystem_Client.__c__DisplayClass_HandleResetScheduleNotificationEvents.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
