// Decompiled with JetBrains decompiler
// Type: ProjectM.DropInventoryItemSystem
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
  public class DropInventoryItemSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DropItemImpairedBuffsQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DropInventoryItemJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DropInventoryItemJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDropInventoryItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013674, XrefRangeEnd = 1013705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropInventoryItemSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropInventoryItemSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013705, XrefRangeEnd = 1013727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropInventoryItemSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropInventoryItemSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013727, XrefRangeEnd = 1013750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropInventoryItemSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013750, XrefRangeEnd = 1013769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDropInventoryItemJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.NativeMethodInfoPtr___GetEntityQuery_ForDropInventoryItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DropInventoryItemSystem()
    {
      Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropInventoryItemSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr);
      DropInventoryItemSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, nameof (_Query));
      DropInventoryItemSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      DropInventoryItemSystem.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, nameof (_GameDataSystem));
      DropInventoryItemSystem.NativeFieldInfoPtr__DropItemImpairedBuffsQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, nameof (_DropItemImpairedBuffsQuery));
      DropInventoryItemSystem.NativeFieldInfoPtr___DropInventoryItemJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, "<>DropInventoryItemJob_entityQuery");
      DropInventoryItemSystem.NativeFieldInfoPtr___DropInventoryItemJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, "<>DropInventoryItemJob_profilerMarker");
      DropInventoryItemSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, 100679015);
      DropInventoryItemSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, 100679016);
      DropInventoryItemSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, 100679017);
      DropInventoryItemSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, 100679018);
      DropInventoryItemSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, 100679019);
      DropInventoryItemSystem.NativeMethodInfoPtr___GetEntityQuery_ForDropInventoryItemJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, 100679020);
    }

    public DropInventoryItemSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DropItemImpairedBuffsQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr__DropItemImpairedBuffsQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr__DropItemImpairedBuffsQuery)) = value;
      }
    }

    public unsafe EntityQuery __DropInventoryItemJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr___DropInventoryItemJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr___DropInventoryItemJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DropInventoryItemJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr___DropInventoryItemJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.NativeFieldInfoPtr___DropInventoryItemJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.DropInventoryItemSystem/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemDataLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropImpairedCharacters;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropInventoryItemEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DropInventoryItemEvent dropItem,
        ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropItem;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropInventoryItemEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr);
        DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
        DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_itemDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (itemDataLookup));
        DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_dropImpairedCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (dropImpairedCharacters));
        DropInventoryItemSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr, 100679021);
        DropInventoryItemSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropInventoryItemEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr, 100679022);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass6_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass6_0>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DropInventoryItemSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DropInventoryItemSystem) null : new DropInventoryItemSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, ItemData> itemDataLookup
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_itemDataLookup));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_itemDataLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<Buff> dropImpairedCharacters
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_dropImpairedCharacters));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_dropImpairedCharacters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.DropInventoryItemSystem/ProjectM.<>c__DisplayClass_DropInventoryItemJob")]
    public sealed class __c__DisplayClass_DropInventoryItemJob : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_itemDataLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr_dropImpairedCharacters;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropInventoryItemEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventoryItemSystem_byref___c__DisplayClass6_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1013641, RefRangeEnd = 1013642, XrefRangeStart = 1013591, XrefRangeEnd = 1013641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DropInventoryItemEvent dropItem,
        ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropItem;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropInventoryItemEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013642, XrefRangeEnd = 1013643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DropInventoryItemSystem.__c__DisplayClass6_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1013644, RefRangeEnd = 1013645, XrefRangeStart = 1013643, XrefRangeEnd = 1013644, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DropInventoryItemSystem.__c__DisplayClass6_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013645, XrefRangeEnd = 1013665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1013671, RefRangeEnd = 1013672, XrefRangeStart = 1013665, XrefRangeEnd = 1013671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1013673, RefRangeEnd = 1013674, XrefRangeStart = 1013672, XrefRangeEnd = 1013673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DropInventoryItemSystem componentSystem,
        ref DropInventoryItemSystem.__c__DisplayClass6_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventoryItemSystem_byref___c__DisplayClass6_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DropInventoryItemJob()
      {
        Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventoryItemSystem>.NativeClassPtr, "<>c__DisplayClass_DropInventoryItemJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr);
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, nameof (networkIdToEntityMap));
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, "<>4__this");
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_itemDataLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, nameof (itemDataLookup));
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_dropImpairedCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, nameof (dropImpairedCharacters));
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, nameof (_runtimes));
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, nameof (_performLambdaDelegate));
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropInventoryItemEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, 100679023);
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, 100679024);
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, 100679025);
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, 100679027);
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, 100679028);
        DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventoryItemSystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, 100679029);
      }

      public __c__DisplayClass_DropInventoryItemJob(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_DropInventoryItemJob()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, data));
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DropInventoryItemSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DropInventoryItemSystem) null : new DropInventoryItemSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe NativeHashMap<PrefabGUID, ItemData> itemDataLookup
      {
        get
        {
          return *(NativeHashMap<PrefabGUID, ItemData>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_itemDataLookup));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_itemDataLookup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<PrefabGUID, ItemData>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe NativeArray<Buff> dropImpairedCharacters
      {
        get
        {
          return *(NativeArray<Buff>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_dropImpairedCharacters));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr_dropImpairedCharacters), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeArray<Buff>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dropItem;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventoryItemSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<DropInventoryItemEvent> forParameter_dropItem;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013575, XrefRangeEnd = 1013582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DropInventoryItemSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventoryItemSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1013590, RefRangeEnd = 1013591, XrefRangeStart = 1013582, XrefRangeEnd = 1013590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dropItem));
          DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropInventoryItemSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders>.NativeClassPtr, 100679030);
          DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders>.NativeClassPtr, 100679031);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dropItem;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<DropInventoryItemEvent>.StructuralChangeRuntime runtime_dropItem;
          [FieldOffset(88)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dropItem));
            DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropInventoryItemSystem.__c__DisplayClass_DropInventoryItemJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
