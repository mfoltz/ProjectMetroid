// Decompiled with JetBrains decompiler
// Type: ProjectM.EquipServantItemFromInventorySystem
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
  public class EquipServantItemFromInventorySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__EquipmentImpairedBuffs;
    private static readonly System.IntPtr NativeFieldInfoPtr___EquipServantItemFromInventoryJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___EquipServantItemFromInventoryJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForEquipServantItemFromInventoryJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018364, XrefRangeEnd = 1018389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EquipServantItemFromInventorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018389, XrefRangeEnd = 1018422, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EquipServantItemFromInventorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EquipServantItemFromInventorySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018422, XrefRangeEnd = 1018445, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EquipServantItemFromInventorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018445, XrefRangeEnd = 1018464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForEquipServantItemFromInventoryJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForEquipServantItemFromInventoryJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static EquipServantItemFromInventorySystem()
    {
      Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (EquipServantItemFromInventorySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr);
      EquipServantItemFromInventorySystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, nameof (_Query));
      EquipServantItemFromInventorySystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      EquipServantItemFromInventorySystem.NativeFieldInfoPtr__EquipmentImpairedBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, nameof (_EquipmentImpairedBuffs));
      EquipServantItemFromInventorySystem.NativeFieldInfoPtr___EquipServantItemFromInventoryJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, "<>EquipServantItemFromInventoryJob_entityQuery");
      EquipServantItemFromInventorySystem.NativeFieldInfoPtr___EquipServantItemFromInventoryJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, "<>EquipServantItemFromInventoryJob_profilerMarker");
      EquipServantItemFromInventorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, 100679406);
      EquipServantItemFromInventorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, 100679407);
      EquipServantItemFromInventorySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, 100679408);
      EquipServantItemFromInventorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, 100679409);
      EquipServantItemFromInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForEquipServantItemFromInventoryJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, 100679410);
    }

    public EquipServantItemFromInventorySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _EquipmentImpairedBuffs
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr__EquipmentImpairedBuffs));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr__EquipmentImpairedBuffs)) = value;
      }
    }

    public unsafe EntityQuery __EquipServantItemFromInventoryJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr___EquipServantItemFromInventoryJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr___EquipServantItemFromInventoryJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __EquipServantItemFromInventoryJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr___EquipServantItemFromInventoryJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.NativeFieldInfoPtr___EquipServantItemFromInventoryJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.EquipServantItemFromInventorySystem/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_handledEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_equipmentImpairedBuffs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EquipServantItemFromInventoryEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref EquipServantItemFromInventoryEvent equipItem,
        ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipItem;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EquipServantItemFromInventoryEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr);
        EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_handledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (handledEvents));
        EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
        EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_equipmentImpairedBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (equipmentImpairedBuffs));
        EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, 100679411);
        EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_EquipServantItemFromInventoryEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, 100679412);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass4_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass4_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> handledEvents
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_handledEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_handledEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EquipServantItemFromInventorySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (EquipServantItemFromInventorySystem) null : new EquipServantItemFromInventorySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<Buff> equipmentImpairedBuffs
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_equipmentImpairedBuffs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass4_0.NativeFieldInfoPtr_equipmentImpairedBuffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.EquipServantItemFromInventorySystem/ProjectM.<>c__DisplayClass_EquipServantItemFromInventoryJob")]
    public sealed class __c__DisplayClass_EquipServantItemFromInventoryJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_handledEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_equipmentImpairedBuffs;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EquipServantItemFromInventoryEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipServantItemFromInventorySystem_byref___c__DisplayClass4_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1018336, RefRangeEnd = 1018337, XrefRangeStart = 1018256, XrefRangeEnd = 1018336, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref EquipServantItemFromInventoryEvent equipItem,
        ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref equipItem;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EquipServantItemFromInventoryEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref EquipServantItemFromInventorySystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1016676, RefRangeEnd = 1016680, XrefRangeStart = 1016676, XrefRangeEnd = 1016680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref EquipServantItemFromInventorySystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018337, XrefRangeEnd = 1018357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1018363, RefRangeEnd = 1018364, XrefRangeStart = 1018357, XrefRangeEnd = 1018363, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1016702, RefRangeEnd = 1016706, XrefRangeStart = 1016702, XrefRangeEnd = 1016706, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        EquipServantItemFromInventorySystem componentSystem,
        ref EquipServantItemFromInventorySystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipServantItemFromInventorySystem_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_EquipServantItemFromInventoryJob()
      {
        Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipServantItemFromInventorySystem>.NativeClassPtr, "<>c__DisplayClass_EquipServantItemFromInventoryJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr);
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_handledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, nameof (handledEvents));
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, "<>4__this");
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_equipmentImpairedBuffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, nameof (equipmentImpairedBuffs));
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, nameof (_runtimes));
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EquipServantItemFromInventoryEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, 100679413);
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, 100679414);
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, 100679415);
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, 100679417);
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, 100679418);
        EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipServantItemFromInventorySystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, 100679419);
      }

      public __c__DisplayClass_EquipServantItemFromInventoryJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_EquipServantItemFromInventoryJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> handledEvents
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_handledEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_handledEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EquipServantItemFromInventorySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (EquipServantItemFromInventorySystem) null : new EquipServantItemFromInventorySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeArray<Buff> equipmentImpairedBuffs
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_equipmentImpairedBuffs));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr_equipmentImpairedBuffs), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_equipItem;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipServantItemFromInventorySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<EquipServantItemFromInventoryEvent> forParameter_equipItem;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018240, XrefRangeEnd = 1018247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          EquipServantItemFromInventorySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipServantItemFromInventorySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1018255, RefRangeEnd = 1018256, XrefRangeStart = 1018247, XrefRangeEnd = 1018255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_equipItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_equipItem));
          EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_EquipServantItemFromInventorySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, 100679420);
          EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, 100679421);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
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
          public LambdaParameterValueProvider_IComponentData<EquipServantItemFromInventoryEvent>.StructuralChangeRuntime runtime_equipItem;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_equipItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_equipItem));
            EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EquipServantItemFromInventorySystem.__c__DisplayClass_EquipServantItemFromInventoryJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
