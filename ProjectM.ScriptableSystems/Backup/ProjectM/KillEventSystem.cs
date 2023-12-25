// Decompiled with JetBrains decompiler
// Type: ProjectM.KillEventSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Physics;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class KillEventSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__CollisionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__NetworkIdSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__RuntimeSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTimeAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr_ALL_FILTER;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645356, XrefRangeEnd = 1645386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645386, XrefRangeEnd = 1645391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645391, XrefRangeEnd = 1645424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe KillEventSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KillEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645424, XrefRangeEnd = 1645450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), KillEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645450, XrefRangeEnd = 1645469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static KillEventSystem()
    {
      Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (KillEventSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr);
      KillEventSystem.NativeFieldInfoPtr__CollisionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, nameof (_CollisionSystem));
      KillEventSystem.NativeFieldInfoPtr__NetworkIdSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, nameof (_NetworkIdSystem));
      KillEventSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, nameof (_Query));
      KillEventSystem.NativeFieldInfoPtr__RuntimeSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, nameof (_RuntimeSettingsAccessor));
      KillEventSystem.NativeFieldInfoPtr__ServerTimeAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, nameof (_ServerTimeAccessor));
      KillEventSystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      KillEventSystem.NativeFieldInfoPtr_ALL_FILTER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, nameof (ALL_FILTER));
      KillEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      KillEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      KillEventSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, 100663679);
      KillEventSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, 100663680);
      KillEventSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, 100663681);
      KillEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, 100663682);
      KillEventSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, 100663684);
      KillEventSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, 100663685);
    }

    public KillEventSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe CollisionSystem _CollisionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__CollisionSystem));
        return pointer == System.IntPtr.Zero ? (CollisionSystem) null : new CollisionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__CollisionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkIdSystem _NetworkIdSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__NetworkIdSystem));
        return pointer == System.IntPtr.Zero ? (NetworkIdSystem) null : new NetworkIdSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__NetworkIdSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe SingletonAccessor<ServerRuntimeSettings> _RuntimeSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerRuntimeSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__RuntimeSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__RuntimeSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerRuntimeSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTimeAccessor
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__ServerTimeAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__ServerTimeAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe CollisionFilter ALL_FILTER
    {
      get
      {
        CollisionFilter allFilter;
        IL2CPP.il2cpp_field_static_get_value(KillEventSystem.NativeFieldInfoPtr_ALL_FILTER, (void*) &allFilter);
        return allFilter;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(KillEventSystem.NativeFieldInfoPtr_ALL_FILTER, (void*) &value);
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.KillEventSystem/<>c__DisplayClass9_0")]
    public sealed class __c__DisplayClass9_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_vampirePvPBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_pvpDebuffPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_KillEvent_byref_FromCharacter_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref KillEvent killEvent, [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref killEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_KillEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr);
        KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
        KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (serverTime));
        KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_vampirePvPBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (vampirePvPBuff));
        KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_pvpDebuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (pvpDebuffPrefab));
        KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (collisionWorld));
        KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (networkIdToEntityMap));
        KillEventSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663686);
        KillEventSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_KillEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663687);
      }

      public __c__DisplayClass9_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass9_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass9_0>.NativeClassPtr, data));
      }

      public unsafe KillEventSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (KillEventSystem) null : new KillEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe PrefabGUID vampirePvPBuff
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_vampirePvPBuff));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_vampirePvPBuff)) = value;
        }
      }

      public unsafe Entity pvpDebuffPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_pvpDebuffPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_pvpDebuffPrefab)) = value;
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }

    [ObfuscatedName("ProjectM.KillEventSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    public sealed class __c__DisplayClass_OnUpdate_LambdaJob0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_serverTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_vampirePvPBuff;
      private static readonly System.IntPtr NativeFieldInfoPtr_pvpDebuffPrefab;
      private static readonly System.IntPtr NativeFieldInfoPtr_collisionWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_networkIdToEntityMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_User_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_KillEvent_byref_FromCharacter_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillEventSystem_byref___c__DisplayClass9_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1645326, RefRangeEnd = 1645327, XrefRangeStart = 1645285, XrefRangeEnd = 1645326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref KillEvent killEvent,
        [In] ref FromCharacter fromCharacter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref killEvent;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref fromCharacter;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_KillEvent_byref_FromCharacter_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1645328, RefRangeEnd = 1645329, XrefRangeStart = 1645327, XrefRangeEnd = 1645328, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref KillEventSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1645330, RefRangeEnd = 1645331, XrefRangeStart = 1645329, XrefRangeEnd = 1645330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref KillEventSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645331, XrefRangeEnd = 1645344, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1645350, RefRangeEnd = 1645351, XrefRangeStart = 1645344, XrefRangeEnd = 1645350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1645355, RefRangeEnd = 1645356, XrefRangeStart = 1645351, XrefRangeEnd = 1645355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        KillEventSystem componentSystem,
        ref KillEventSystem.__c__DisplayClass9_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillEventSystem_byref___c__DisplayClass9_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillEventSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "<>4__this");
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (serverTime));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_vampirePvPBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (vampirePvPBuff));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_pvpDebuffPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (pvpDebuffPrefab));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_collisionWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (collisionWorld));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_networkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (networkIdToEntityMap));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_User_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_ComponentDataFromEntity_User_0));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_performLambdaDelegate));
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_KillEvent_byref_FromCharacter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663688);
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663689);
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663690);
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663692);
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663693);
        KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillEventSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100663694);
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, data));
      }

      public unsafe KillEventSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (KillEventSystem) null : new KillEventSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe double serverTime
      {
        get
        {
          return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime));
        }
        [param: In] set
        {
          *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_serverTime)) = value;
        }
      }

      public unsafe PrefabGUID vampirePvPBuff
      {
        get
        {
          return *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_vampirePvPBuff));
        }
        [param: In] set
        {
          *(PrefabGUID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_vampirePvPBuff)) = value;
        }
      }

      public unsafe Entity pvpDebuffPrefab
      {
        get
        {
          return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_pvpDebuffPrefab));
        }
        [param: In] set
        {
          *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_pvpDebuffPrefab)) = value;
        }
      }

      public unsafe CollisionWorld collisionWorld
      {
        get
        {
          return *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_collisionWorld));
        }
        [param: In] set
        {
          *(CollisionWorld*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_collisionWorld)) = value;
        }
      }

      public unsafe NativeHashMap<NetworkId, Entity> networkIdToEntityMap
      {
        get
        {
          return *(NativeHashMap<NetworkId, Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_networkIdToEntityMap));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_networkIdToEntityMap), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashMap<NetworkId, Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ComponentDataFromEntity<User> _ComponentDataFromEntity_User_0
      {
        get
        {
          return *(ComponentDataFromEntity<User>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_User_0));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__ComponentDataFromEntity_User_0), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ComponentDataFromEntity<User>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_killEvent;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_fromCharacter;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillEventSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<KillEvent> forParameter_killEvent;
        [FieldOffset(32)]
        public LambdaParameterValueProvider_IComponentData<FromCharacter> forParameter_fromCharacter;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1645271, XrefRangeEnd = 1645277, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(KillEventSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillEventSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1645284, RefRangeEnd = 1645285, XrefRangeStart = 1645277, XrefRangeEnd = 1645284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_killEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_killEvent));
          KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_fromCharacter));
          KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_KillEventSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663695);
          KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100663696);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_killEvent;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_fromCharacter;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<KillEvent>.StructuralChangeRuntime runtime_killEvent;
          [FieldOffset(80)]
          public LambdaParameterValueProvider_IComponentData<FromCharacter>.StructuralChangeRuntime runtime_fromCharacter;

          static Runtimes()
          {
            Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_killEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_killEvent));
            KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_fromCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_fromCharacter));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KillEventSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
