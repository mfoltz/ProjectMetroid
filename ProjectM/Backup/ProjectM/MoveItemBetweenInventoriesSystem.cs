// Decompiled with JetBrains decompiler
// Type: ProjectM.MoveItemBetweenInventoriesSystem
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
  public class MoveItemBetweenInventoriesSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__MoveItemBetweenInventoriesEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___MoveItemsJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___MoveItemsJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForMoveItemsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020949, XrefRangeEnd = 1020960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020960, XrefRangeEnd = 1020976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoveItemBetweenInventoriesSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020976, XrefRangeEnd = 1020999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020999, XrefRangeEnd = 1021018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForMoveItemsJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr___GetEntityQuery_ForMoveItemsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MoveItemBetweenInventoriesSystem()
    {
      Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MoveItemBetweenInventoriesSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr);
      MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__MoveItemBetweenInventoriesEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, nameof (_MoveItemBetweenInventoriesEventQuery));
      MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, nameof (_GameDataSystem));
      MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr___MoveItemsJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, "<>MoveItemsJob_entityQuery");
      MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr___MoveItemsJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, "<>MoveItemsJob_profilerMarker");
      MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, 100679664);
      MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, 100679665);
      MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, 100679666);
      MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, 100679667);
      MoveItemBetweenInventoriesSystem.NativeMethodInfoPtr___GetEntityQuery_ForMoveItemsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, 100679668);
    }

    public MoveItemBetweenInventoriesSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _MoveItemBetweenInventoriesEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__MoveItemBetweenInventoriesEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__MoveItemBetweenInventoriesEventQuery)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __MoveItemsJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr___MoveItemsJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr___MoveItemsJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __MoveItemsJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr___MoveItemsJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.NativeFieldInfoPtr___MoveItemsJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.MoveItemBetweenInventoriesSystem/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemDataMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_MoveItemBetweenInventoriesEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref MoveItemBetweenInventoriesEvent moveEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_MoveItemBetweenInventoriesEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr);
        MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
        MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_itemDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr, nameof (itemDataMap));
        MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr, 100679669);
        MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_MoveItemBetweenInventoriesEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr, 100679670);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass4_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe MoveItemBetweenInventoriesSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MoveItemBetweenInventoriesSystem) null : new MoveItemBetweenInventoriesSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, ItemData> itemDataMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_itemDataMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0.NativeFieldInfoPtr_itemDataMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.MoveItemBetweenInventoriesSystem/ProjectM.<>c__DisplayClass_MoveItemsJob")]
    public sealed class __c__DisplayClass_MoveItemsJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemDataMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MoveItemBetweenInventoriesEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveItemBetweenInventoriesSystem_byref___c__DisplayClass4_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1020924, RefRangeEnd = 1020925, XrefRangeStart = 1020871, XrefRangeEnd = 1020924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref MoveItemBetweenInventoriesEvent moveEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref moveEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MoveItemBetweenInventoriesEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(12)]
      [CachedScanResults(RefRangeStart = 1018528, RefRangeEnd = 1018540, XrefRangeStart = 1018528, XrefRangeEnd = 1018540, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020925, XrefRangeEnd = 1020942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1020948, RefRangeEnd = 1020949, XrefRangeStart = 1020942, XrefRangeEnd = 1020948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1018565, RefRangeEnd = 1018576, XrefRangeStart = 1018565, XrefRangeEnd = 1018576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        MoveItemBetweenInventoriesSystem componentSystem,
        ref MoveItemBetweenInventoriesSystem.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveItemBetweenInventoriesSystem_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_MoveItemsJob()
      {
        Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem>.NativeClassPtr, "<>c__DisplayClass_MoveItemsJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr);
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, "<>4__this");
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr_itemDataMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, nameof (itemDataMap));
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, nameof (_runtimes));
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MoveItemBetweenInventoriesEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, 100679671);
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, 100679672);
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, 100679673);
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, 100679675);
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, 100679676);
        MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveItemBetweenInventoriesSystem_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, 100679677);
      }

      public __c__DisplayClass_MoveItemsJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_MoveItemsJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe MoveItemBetweenInventoriesSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (MoveItemBetweenInventoriesSystem) null : new MoveItemBetweenInventoriesSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, ItemData> itemDataMap
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr_itemDataMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr_itemDataMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_moveEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveItemBetweenInventoriesSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<MoveItemBetweenInventoriesEvent> forParameter_moveEvent;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020855, XrefRangeEnd = 1020862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(MoveItemBetweenInventoriesSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveItemBetweenInventoriesSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1020870, RefRangeEnd = 1020871, XrefRangeStart = 1020862, XrefRangeEnd = 1020870, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_moveEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_moveEvent));
          MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_MoveItemBetweenInventoriesSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679678);
          MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679679);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_moveEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<MoveItemBetweenInventoriesEvent>.StructuralChangeRuntime runtime_moveEvent;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_moveEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_moveEvent));
            MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MoveItemBetweenInventoriesSystem.__c__DisplayClass_MoveItemsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
