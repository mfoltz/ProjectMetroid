// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.CreateGameplayEventsOnDeathSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class CreateGameplayEventsOnDeathSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__GameplayEventsSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateEventOnDeath_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateEventOnDeath_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateEventOnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442752, XrefRangeEnd = 1442758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442758, XrefRangeEnd = 1442787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateGameplayEventsOnDeathSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442787, XrefRangeEnd = 1442820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442820, XrefRangeEnd = 1442836, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateEventOnDeath_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateEventOnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1442840, RefRangeEnd = 1442841, XrefRangeStart = 1442836, XrefRangeEnd = 1442840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateGameplayEventsOnDeathSystem()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (CreateGameplayEventsOnDeathSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr);
      CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr__GameplayEventsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, nameof (_GameplayEventsSystem));
      CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr___CreateEventOnDeath_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, "<>CreateEventOnDeath_entityQuery");
      CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr___CreateEventOnDeath_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, "<>CreateEventOnDeath_profilerMarker");
      CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, 100671990);
      CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, 100671991);
      CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, 100671992);
      CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, 100671993);
      CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateEventOnDeath_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, 100671994);
      CreateGameplayEventsOnDeathSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, 100671995);
    }

    public CreateGameplayEventsOnDeathSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayEventsSystem _GameplayEventsSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr__GameplayEventsSystem));
        return pointer == System.IntPtr.Zero ? (GameplayEventsSystem) null : new GameplayEventsSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr__GameplayEventsSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __CreateEventOnDeath_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr___CreateEventOnDeath_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr___CreateEventOnDeath_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateEventOnDeath_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr___CreateEventOnDeath_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.NativeFieldInfoPtr___CreateEventOnDeath_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.CreateGameplayEventsOnDeathSystem/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getCreateGameplayEventOnDeath;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAttachedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBuff;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DeathEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref DeathEvent triggerEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref triggerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DeathEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (commandBuffer));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getCreateGameplayEventOnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (getCreateGameplayEventOnDeath));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_gameplayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (gameplayEvents));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getAttachedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (getAttachedBuffer));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (getBuff));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, 100671996);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, 100671997);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe BufferFromEntity<CreateGameplayEventOnDeath> getCreateGameplayEventOnDeath
      {
        get
        {
          return *(BufferFromEntity<CreateGameplayEventOnDeath>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getCreateGameplayEventOnDeath));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getCreateGameplayEventOnDeath), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<CreateGameplayEventOnDeath>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe CreateGameplayEventsOnDeathSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CreateGameplayEventsOnDeathSystem) null : new CreateGameplayEventsOnDeathSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeList<GameplayEvent> gameplayEvents
      {
        get
        {
          return *(NativeList<GameplayEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_gameplayEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_gameplayEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<GameplayEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe BufferFromEntity<AttachedBuffer> getAttachedBuffer
      {
        get
        {
          return *(BufferFromEntity<AttachedBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getAttachedBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getAttachedBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<AttachedBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<Buff> getBuff
      {
        get
        {
          return *(ComponentDataFromEntity<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getBuff));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_getBuff), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.CreateGameplayEventsOnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateEventOnDeath")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateEventOnDeath
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getCreateGameplayEventOnDeath;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAttachedBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DeathEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDeathSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public BufferFromEntity<CreateGameplayEventOnDeath> getCreateGameplayEventOnDeath;
      [FieldOffset(56)]
      public NativeList<GameplayEvent> gameplayEvents;
      [FieldOffset(72)]
      public BufferFromEntity<AttachedBuffer> getAttachedBuffer;
      [FieldOffset(112)]
      public ComponentDataFromEntity<Buff> getBuff;
      [FieldOffset(144)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(176)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_1;
      [FieldOffset(208)]
      public CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(248)]
      public unsafe CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442649, XrefRangeEnd = 1442722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref DeathEvent triggerEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref triggerEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DeathEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1442722, RefRangeEnd = 1442723, XrefRangeStart = 1442722, XrefRangeEnd = 1442722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1442723, RefRangeEnd = 1442724, XrefRangeStart = 1442723, XrefRangeEnd = 1442723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442724, XrefRangeEnd = 1442726, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1442732, RefRangeEnd = 1442733, XrefRangeStart = 1442726, XrefRangeEnd = 1442732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1442741, RefRangeEnd = 1442742, XrefRangeStart = 1442733, XrefRangeEnd = 1442741, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CreateGameplayEventsOnDeathSystem componentSystem,
        ref CreateGameplayEventsOnDeathSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDeathSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442742, XrefRangeEnd = 1442746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442746, XrefRangeEnd = 1442752, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateEventOnDeath()
      {
        Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem>.NativeClassPtr, "<>c__DisplayClass_CreateEventOnDeath");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (commandBuffer));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_getCreateGameplayEventOnDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (getCreateGameplayEventOnDeath));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_gameplayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (gameplayEvents));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_getAttachedBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (getAttachedBuffer));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_getBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (getBuff));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_1));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (_runtimes));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, 100671998);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, 100671999);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, 100672000);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, 100672001);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, 100672002);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDeathSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, 100672003);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, 100672004);
        CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, 100672005);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_triggerEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDeathSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<DeathEvent> forParameter_triggerEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1442568, RefRangeEnd = 1442569, XrefRangeStart = 1442564, XrefRangeEnd = 1442568, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CreateGameplayEventsOnDeathSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDeathSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1442573, RefRangeEnd = 1442574, XrefRangeStart = 1442569, XrefRangeEnd = 1442573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_triggerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_triggerEvent));
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDeathSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders>.NativeClassPtr, 100672006);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders>.NativeClassPtr, 100672007);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_triggerEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<DeathEvent>.Runtime runtime_triggerEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_triggerEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_triggerEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.CreateGameplayEventsOnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateEventOnDeath/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000014E0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, "RunWithoutJobSystem_000014E0$PostfixBurstDelegate");
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672008);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672009);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672010);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672011);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.CreateGameplayEventsOnDeathSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateEventOnDeath/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000014E0$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442574, XrefRangeEnd = 1442588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442588, XrefRangeEnd = 1442606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442606, XrefRangeEnd = 1442621, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1442648, RefRangeEnd = 1442649, XrefRangeStart = 1442621, XrefRangeEnd = 1442648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath>.NativeClassPtr, "RunWithoutJobSystem_000014E0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672012);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672013);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672014);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672015);
          CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672017);
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
            IL2CPP.il2cpp_field_static_get_value(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CreateGameplayEventsOnDeathSystem.__c__DisplayClass_CreateEventOnDeath.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
