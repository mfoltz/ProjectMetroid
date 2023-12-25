// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.CreateGameplayEventsOnDamageTakenSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Shared;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class CreateGameplayEventsOnDamageTakenSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CreateGameplayEventsOnDamageTakenQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__DamageTakenEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConditionCheckerFactory;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameplayEventsSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateEventOnDamageTaken_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateEventOnDamageTaken_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateEventOnDamageTaken_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443036, XrefRangeEnd = 1443054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443054, XrefRangeEnd = 1443082, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateGameplayEventsOnDamageTakenSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443082, XrefRangeEnd = 1443115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443115, XrefRangeEnd = 1443131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateEventOnDamageTaken_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateEventOnDamageTaken_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1443135, RefRangeEnd = 1443136, XrefRangeStart = 1443131, XrefRangeEnd = 1443135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateGameplayEventsOnDamageTakenSystem()
    {
      Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (CreateGameplayEventsOnDamageTakenSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr);
      CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__CreateGameplayEventsOnDamageTakenQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, nameof (_CreateGameplayEventsOnDamageTakenQuery));
      CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__DamageTakenEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, nameof (_DamageTakenEventQuery));
      CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__ConditionCheckerFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, nameof (_ConditionCheckerFactory));
      CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__GameplayEventsSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, nameof (_GameplayEventsSystem));
      CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr___CreateEventOnDamageTaken_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, "<>CreateEventOnDamageTaken_entityQuery");
      CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr___CreateEventOnDamageTaken_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, "<>CreateEventOnDamageTaken_profilerMarker");
      CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, 100672018);
      CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, 100672019);
      CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, 100672020);
      CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, 100672021);
      CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, 100672022);
      CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr___GetEntityQuery_ForCreateEventOnDamageTaken_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, 100672023);
      CreateGameplayEventsOnDamageTakenSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, 100672024);
    }

    public CreateGameplayEventsOnDamageTakenSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _CreateGameplayEventsOnDamageTakenQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__CreateGameplayEventsOnDamageTakenQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__CreateGameplayEventsOnDamageTakenQuery)) = value;
      }
    }

    public unsafe EntityQuery _DamageTakenEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__DamageTakenEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__DamageTakenEventQuery)) = value;
      }
    }

    public unsafe ConditionCheckerFactory _ConditionCheckerFactory
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__ConditionCheckerFactory));
        return pointer == System.IntPtr.Zero ? (ConditionCheckerFactory) null : new ConditionCheckerFactory(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__ConditionCheckerFactory), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameplayEventsSystem _GameplayEventsSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__GameplayEventsSystem));
        return pointer == System.IntPtr.Zero ? (GameplayEventsSystem) null : new GameplayEventsSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr__GameplayEventsSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __CreateEventOnDamageTaken_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr___CreateEventOnDamageTaken_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr___CreateEventOnDamageTaken_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateEventOnDamageTaken_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr___CreateEventOnDamageTaken_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.NativeFieldInfoPtr___CreateEventOnDamageTaken_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.CreateGameplayEventsOnDamageTakenSystem/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_createOnDamageTakenEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEvents;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DamageTakenEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref DamageTakenEvent takeDamageEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref takeDamageEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DamageTakenEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (commandBuffer));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_createOnDamageTakenEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (createOnDamageTakenEntities));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (conditionChecker));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_gameplayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (gameplayEvents));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, 100672025);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DamageTakenEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, 100672026);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass6_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0>.NativeClassPtr, data));
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe NativeArray<Entity> createOnDamageTakenEntities
      {
        get
        {
          return *(NativeArray<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_createOnDamageTakenEntities));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_createOnDamageTakenEntities), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe CreateGameplayEventsOnDamageTakenSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CreateGameplayEventsOnDamageTakenSystem) null : new CreateGameplayEventsOnDamageTakenSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ConditionChecker conditionChecker
      {
        get
        {
          return *(ConditionChecker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conditionChecker));
        }
        [param: In] set
        {
          *(ConditionChecker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conditionChecker)) = value;
        }
      }

      public unsafe NativeList<GameplayEvent> gameplayEvents
      {
        get
        {
          return *(NativeList<GameplayEvent>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_gameplayEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_gameplayEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<GameplayEvent>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.CreateGameplayEventsOnDamageTakenSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateEventOnDamageTaken")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateEventOnDamageTaken
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_createOnDamageTakenEntities;
      private static readonly System.IntPtr NativeFieldInfoPtr_conditionChecker;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameplayEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_CreateGameplayEventOnDamageTaken_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Buff_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_SpellTarget_3;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_4;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_5;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DamageTakenEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDamageTakenSystem_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public NativeArray<Entity> createOnDamageTakenEntities;
      [FieldOffset(32)]
      public ConditionChecker conditionChecker;
      [FieldOffset(2232)]
      public NativeList<GameplayEvent> gameplayEvents;
      [FieldOffset(2248)]
      public BufferFromEntity<CreateGameplayEventOnDamageTaken> _BufferFromEntity_CreateGameplayEventOnDamageTaken_0;
      [FieldOffset(2288)]
      public ComponentDataFromEntity<EntityOwner> _ComponentDataFromEntity_EntityOwner_1;
      [FieldOffset(2320)]
      public ComponentDataFromEntity<Buff> _ComponentDataFromEntity_Buff_2;
      [FieldOffset(2352)]
      public ComponentDataFromEntity<SpellTarget> _ComponentDataFromEntity_SpellTarget_3;
      [FieldOffset(2384)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_4;
      [FieldOffset(2416)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_5;
      [FieldOffset(2448)]
      public CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(2488)]
      public unsafe CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442932, XrefRangeEnd = 1442992, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref DamageTakenEvent takeDamageEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref takeDamageEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DamageTakenEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1442993, RefRangeEnd = 1442994, XrefRangeStart = 1442992, XrefRangeEnd = 1442993, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1442995, RefRangeEnd = 1442996, XrefRangeStart = 1442994, XrefRangeEnd = 1442995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442996, XrefRangeEnd = 1442998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443004, RefRangeEnd = 1443005, XrefRangeStart = 1442998, XrefRangeEnd = 1443004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1443025, RefRangeEnd = 1443026, XrefRangeStart = 1443005, XrefRangeEnd = 1443025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CreateGameplayEventsOnDamageTakenSystem componentSystem,
        ref CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDamageTakenSystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443026, XrefRangeEnd = 1443030, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1443030, XrefRangeEnd = 1443036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateEventOnDamageTaken()
      {
        Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem>.NativeClassPtr, "<>c__DisplayClass_CreateEventOnDamageTaken");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (commandBuffer));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_createOnDamageTakenEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (createOnDamageTakenEntities));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_conditionChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (conditionChecker));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_gameplayEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (gameplayEvents));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr__BufferFromEntity_CreateGameplayEventOnDamageTaken_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (_BufferFromEntity_CreateGameplayEventOnDamageTaken_0));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr__ComponentDataFromEntity_EntityOwner_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (_ComponentDataFromEntity_EntityOwner_1));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr__ComponentDataFromEntity_Buff_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (_ComponentDataFromEntity_Buff_2));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr__ComponentDataFromEntity_SpellTarget_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (_ComponentDataFromEntity_SpellTarget_3));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_4));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_5));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (_runtimes));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DamageTakenEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, 100672027);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, 100672028);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, 100672029);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, 100672030);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, 100672031);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDamageTakenSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, 100672032);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, 100672033);
        CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, 100672034);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_takeDamageEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDamageTakenSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<DamageTakenEvent> forParameter_takeDamageEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1442845, RefRangeEnd = 1442846, XrefRangeStart = 1442841, XrefRangeEnd = 1442845, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          CreateGameplayEventsOnDamageTakenSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDamageTakenSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1442850, RefRangeEnd = 1442851, XrefRangeStart = 1442846, XrefRangeEnd = 1442850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_takeDamageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_takeDamageEvent));
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CreateGameplayEventsOnDamageTakenSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders>.NativeClassPtr, 100672035);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders>.NativeClassPtr, 100672036);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_takeDamageEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<DamageTakenEvent>.Runtime runtime_takeDamageEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_takeDamageEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_takeDamageEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.CreateGameplayEventsOnDamageTakenSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateEventOnDamageTaken/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000014F1$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, "RunWithoutJobSystem_000014F1$PostfixBurstDelegate");
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672037);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672038);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672039);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672040);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.CreateGameplayEventsOnDamageTakenSystem/ProjectM.Gameplay.Systems.<>c__DisplayClass_CreateEventOnDamageTaken/ProjectM.Gameplay.Systems.RunWithoutJobSystem_000014F1$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442851, XrefRangeEnd = 1442865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442865, XrefRangeEnd = 1442883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1442883, XrefRangeEnd = 1442898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1442931, RefRangeEnd = 1442932, XrefRangeStart = 1442898, XrefRangeEnd = 1442931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken>.NativeClassPtr, "RunWithoutJobSystem_000014F1$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672041);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672042);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672043);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672044);
          CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672046);
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
            IL2CPP.il2cpp_field_static_get_value(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CreateGameplayEventsOnDamageTakenSystem.__c__DisplayClass_CreateEventOnDamageTaken.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
