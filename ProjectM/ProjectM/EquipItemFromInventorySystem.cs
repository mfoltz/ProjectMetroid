// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipItemFromInventorySystem
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
namespace ProjectM
{
  public class EquipItemFromInventorySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EquipmentImpairedBuffs;
    private static readonly System.IntPtr NativeFieldInfoPtr___EquipItemFromInventoryJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___EquipItemFromInventoryJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForEquipItemFromInventoryJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017172, XrefRangeEnd = 1017197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EquipItemFromInventorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017197, XrefRangeEnd = 1017230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EquipItemFromInventorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EquipItemFromInventorySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017230, XrefRangeEnd = 1017253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EquipItemFromInventorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017253, XrefRangeEnd = 1017272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForEquipItemFromInventoryJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForEquipItemFromInventoryJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EquipItemFromInventorySystem()
    {
      Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EquipItemFromInventorySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr);
      EquipItemFromInventorySystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, nameof (_Query));
      EquipItemFromInventorySystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      EquipItemFromInventorySystem.NativeFieldInfoPtr__EquipmentImpairedBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, nameof (_EquipmentImpairedBuffs));
      EquipItemFromInventorySystem.NativeFieldInfoPtr___EquipItemFromInventoryJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, "<>EquipItemFromInventoryJob_entityQuery");
      EquipItemFromInventorySystem.NativeFieldInfoPtr___EquipItemFromInventoryJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, "<>EquipItemFromInventoryJob_profilerMarker");
      EquipItemFromInventorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, 100679314);
      EquipItemFromInventorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, 100679315);
      EquipItemFromInventorySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, 100679316);
      EquipItemFromInventorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, 100679317);
      EquipItemFromInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForEquipItemFromInventoryJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, 100679318);
    }

    public EquipItemFromInventorySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EquipmentImpairedBuffs
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr__EquipmentImpairedBuffs));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr__EquipmentImpairedBuffs)) = value;
      }
    }

    public unsafe EntityQuery __EquipItemFromInventoryJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr___EquipItemFromInventoryJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr___EquipItemFromInventoryJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __EquipItemFromInventoryJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr___EquipItemFromInventoryJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.NativeFieldInfoPtr___EquipItemFromInventoryJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.EquipItemFromInventorySystem/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_handledEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_equipmentImpairBuffs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EquipItemFromInventoryEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref EquipItemFromInventoryEvent equipItem,
        ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipItem;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EquipItemFromInventoryEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr);
        EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_handledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (handledEvents));
        EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
        EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_equipmentImpairBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (equipmentImpairBuffs));
        EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, 100679319);
        EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EquipItemFromInventoryEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, 100679320);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass4_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> handledEvents
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_handledEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_handledEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EquipItemFromInventorySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (EquipItemFromInventorySystem) null : new EquipItemFromInventorySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<Buff> equipmentImpairBuffs
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_equipmentImpairBuffs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_equipmentImpairBuffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.EquipItemFromInventorySystem/ProjectM.<>c__DisplayClass_EquipItemFromInventoryJob")]
    public sealed class __c__DisplayClass_EquipItemFromInventoryJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_handledEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_equipmentImpairBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EquipItemFromInventoryEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipItemFromInventorySystem_byref___c__DisplayClass4_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1017144, RefRangeEnd = 1017145, XrefRangeStart = 1017058, XrefRangeEnd = 1017144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref EquipItemFromInventoryEvent equipItem,
        ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipItem;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EquipItemFromInventoryEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref EquipItemFromInventorySystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1016676, RefRangeEnd = 1016680, XrefRangeStart = 1016676, XrefRangeEnd = 1016680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref EquipItemFromInventorySystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017145, XrefRangeEnd = 1017165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1017171, RefRangeEnd = 1017172, XrefRangeStart = 1017165, XrefRangeEnd = 1017171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1016702, RefRangeEnd = 1016706, XrefRangeStart = 1016702, XrefRangeEnd = 1016706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        EquipItemFromInventorySystem componentSystem,
        ref EquipItemFromInventorySystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipItemFromInventorySystem_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_EquipItemFromInventoryJob()
      {
        Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipItemFromInventorySystem>.NativeClassPtr, "<>c__DisplayClass_EquipItemFromInventoryJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr);
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_handledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, nameof (handledEvents));
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, "<>4__this");
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_equipmentImpairBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, nameof (equipmentImpairBuffs));
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, nameof (_runtimes));
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EquipItemFromInventoryEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, 100679321);
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, 100679322);
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, 100679323);
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, 100679325);
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, 100679326);
        EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipItemFromInventorySystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, 100679327);
      }

      public __c__DisplayClass_EquipItemFromInventoryJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_EquipItemFromInventoryJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> handledEvents
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_handledEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_handledEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EquipItemFromInventorySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (EquipItemFromInventorySystem) null : new EquipItemFromInventorySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<Buff> equipmentImpairBuffs
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_equipmentImpairBuffs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr_equipmentImpairBuffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_equipItem;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipItemFromInventorySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<EquipItemFromInventoryEvent> forParameter_equipItem;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017042, XrefRangeEnd = 1017049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(EquipItemFromInventorySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipItemFromInventorySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1017057, RefRangeEnd = 1017058, XrefRangeStart = 1017049, XrefRangeEnd = 1017057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_equipItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_equipItem));
          EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipItemFromInventorySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, 100679328);
          EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, 100679329);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_equipItem;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<EquipItemFromInventoryEvent>.StructuralChangeRuntime runtime_equipItem;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_equipItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_equipItem));
            EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipItemFromInventorySystem.__c__DisplayClass_EquipItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
