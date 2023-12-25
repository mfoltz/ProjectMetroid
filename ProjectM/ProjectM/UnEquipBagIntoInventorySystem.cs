// Decompiled with JetBrains decompiler
// Type: ProjectM.UnEquipBagIntoInventorySystem
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
  public class UnEquipBagIntoInventorySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__EventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___UnEquipBagJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UnEquipBagJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUnEquipBagJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016262, XrefRangeEnd = 1016278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnEquipBagIntoInventorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016278, XrefRangeEnd = 1016314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnEquipBagIntoInventorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe UnEquipBagIntoInventorySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016314, XrefRangeEnd = 1016337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UnEquipBagIntoInventorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016337, XrefRangeEnd = 1016356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUnEquipBagJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForUnEquipBagJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UnEquipBagIntoInventorySystem()
    {
      Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (UnEquipBagIntoInventorySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr);
      UnEquipBagIntoInventorySystem.NativeFieldInfoPtr__EventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, nameof (_EventQuery));
      UnEquipBagIntoInventorySystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      UnEquipBagIntoInventorySystem.NativeFieldInfoPtr___UnEquipBagJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, "<>UnEquipBagJob_entityQuery");
      UnEquipBagIntoInventorySystem.NativeFieldInfoPtr___UnEquipBagJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, "<>UnEquipBagJob_profilerMarker");
      UnEquipBagIntoInventorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, 100679262);
      UnEquipBagIntoInventorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, 100679263);
      UnEquipBagIntoInventorySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, 100679264);
      UnEquipBagIntoInventorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, 100679265);
      UnEquipBagIntoInventorySystem.NativeMethodInfoPtr___GetEntityQuery_ForUnEquipBagJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, 100679266);
    }

    public UnEquipBagIntoInventorySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _EventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.NativeFieldInfoPtr__EventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.NativeFieldInfoPtr__EventQuery)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __UnEquipBagJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.NativeFieldInfoPtr___UnEquipBagJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.NativeFieldInfoPtr___UnEquipBagJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UnEquipBagJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.NativeFieldInfoPtr___UnEquipBagJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.NativeFieldInfoPtr___UnEquipBagJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.UnEquipBagIntoInventorySystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_handledThisFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_handledEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_UnequipBagIntoInventoryEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref UnequipBagIntoInventoryEvent unEquipBagEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref unEquipBagEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_UnequipBagIntoInventoryEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr);
        UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_handledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (handledThisFrame));
        UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_handledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (handledEvents));
        UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (gameDataSystem));
        UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, 100679267);
        UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_UnequipBagIntoInventoryEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, 100679268);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> handledThisFrame
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_handledThisFrame));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_handledThisFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> handledEvents
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_handledEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_handledEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe UnEquipBagIntoInventorySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UnEquipBagIntoInventorySystem) null : new UnEquipBagIntoInventorySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass3_0.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.UnEquipBagIntoInventorySystem/ProjectM.<>c__DisplayClass_UnEquipBagJob")]
    public sealed class __c__DisplayClass_UnEquipBagJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_handledThisFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr_handledEvents;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_gameDataSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnequipBagIntoInventoryEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnEquipBagIntoInventorySystem_byref___c__DisplayClass3_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1016240, RefRangeEnd = 1016241, XrefRangeStart = 1016225, XrefRangeEnd = 1016240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref UnequipBagIntoInventoryEvent unEquipBagEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref unEquipBagEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnequipBagIntoInventoryEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref UnEquipBagIntoInventorySystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1015773, RefRangeEnd = 1015775, XrefRangeStart = 1015773, XrefRangeEnd = 1015775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref UnEquipBagIntoInventorySystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016241, XrefRangeEnd = 1016255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1016261, RefRangeEnd = 1016262, XrefRangeStart = 1016255, XrefRangeEnd = 1016261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1015798, RefRangeEnd = 1015800, XrefRangeStart = 1015798, XrefRangeEnd = 1015800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        UnEquipBagIntoInventorySystem componentSystem,
        ref UnEquipBagIntoInventorySystem.__c__DisplayClass3_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnEquipBagIntoInventorySystem_byref___c__DisplayClass3_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UnEquipBagJob()
      {
        Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem>.NativeClassPtr, "<>c__DisplayClass_UnEquipBagJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr);
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_handledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, nameof (handledThisFrame));
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_handledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, nameof (handledEvents));
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, "<>4__this");
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_gameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, nameof (gameDataSystem));
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, nameof (_runtimes));
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_UnequipBagIntoInventoryEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, 100679269);
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, 100679270);
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, 100679271);
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, 100679273);
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, 100679274);
        UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnEquipBagIntoInventorySystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, 100679275);
      }

      public __c__DisplayClass_UnEquipBagJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_UnEquipBagJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, data));
      }

      public unsafe NativeList<Entity> handledThisFrame
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_handledThisFrame));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_handledThisFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeList<Entity> handledEvents
      {
        get
        {
          return *(NativeList<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_handledEvents));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_handledEvents), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe UnEquipBagIntoInventorySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (UnEquipBagIntoInventorySystem) null : new UnEquipBagIntoInventorySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe GameDataSystem gameDataSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_gameDataSystem));
          return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr_gameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_unEquipBagEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnEquipBagIntoInventorySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<UnequipBagIntoInventoryEvent> forParameter_unEquipBagEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016209, XrefRangeEnd = 1016216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(UnEquipBagIntoInventorySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnEquipBagIntoInventorySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1016224, RefRangeEnd = 1016225, XrefRangeStart = 1016216, XrefRangeEnd = 1016224, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_unEquipBagEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_unEquipBagEvent));
          UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_UnEquipBagIntoInventorySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders>.NativeClassPtr, 100679276);
          UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders>.NativeClassPtr, 100679277);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_unEquipBagEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<UnequipBagIntoInventoryEvent>.StructuralChangeRuntime runtime_unEquipBagEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_unEquipBagEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_unEquipBagEvent));
            UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnEquipBagIntoInventorySystem.__c__DisplayClass_UnEquipBagJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
