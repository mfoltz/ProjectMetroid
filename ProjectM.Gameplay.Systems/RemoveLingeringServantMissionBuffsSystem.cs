// Decompiled with JetBrains decompiler
// Type: ProjectM.RemoveLingeringServantMissionBuffsSystem
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class RemoveLingeringServantMissionBuffsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PostUpdateBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServantMissionSettingsAccessor;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastQueriedEntityIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__BuffSpawnerSystemData;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckIfAnyActiveMissionContainsServant_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CheckIfAnyActiveMissionContainsServant_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCheckIfAnyActiveMissionContainsServant_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419759, XrefRangeEnd = 1419771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419771, XrefRangeEnd = 1419773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419773, XrefRangeEnd = 1419815, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RemoveLingeringServantMissionBuffsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419815, XrefRangeEnd = 1419879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419879, XrefRangeEnd = 1419895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForOnUpdate_LambdaJob0_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419895, XrefRangeEnd = 1419911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCheckIfAnyActiveMissionContainsServant_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckIfAnyActiveMissionContainsServant_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1419915, RefRangeEnd = 1419916, XrefRangeStart = 1419911, XrefRangeEnd = 1419915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1419920, RefRangeEnd = 1419921, XrefRangeStart = 1419916, XrefRangeEnd = 1419920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RemoveLingeringServantMissionBuffsSystem()
    {
      Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (RemoveLingeringServantMissionBuffsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr);
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__PostUpdateBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, nameof (_PostUpdateBarrier));
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__ServantMissionSettingsAccessor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, nameof (_ServantMissionSettingsAccessor));
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__LastQueriedEntityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, nameof (_LastQueriedEntityIndex));
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, nameof (_Query));
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__BuffSpawnerSystemData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, nameof (_BuffSpawnerSystemData));
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_entityQuery");
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, "<>OnUpdate_LambdaJob0_profilerMarker");
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___CheckIfAnyActiveMissionContainsServant_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, "<>CheckIfAnyActiveMissionContainsServant_entityQuery");
      RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___CheckIfAnyActiveMissionContainsServant_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, "<>CheckIfAnyActiveMissionContainsServant_profilerMarker");
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669511);
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669512);
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669513);
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669514);
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669515);
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr___GetEntityQuery_ForOnUpdate_LambdaJob0_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669516);
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr___GetEntityQuery_ForCheckIfAnyActiveMissionContainsServant_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669517);
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669518);
      RemoveLingeringServantMissionBuffsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, 100669519);
    }

    public RemoveLingeringServantMissionBuffsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PostUpdateBarrier _PostUpdateBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__PostUpdateBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__PostUpdateBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServantMissionSettingsSingleton> _ServantMissionSettingsAccessor
    {
      get
      {
        return *(SingletonAccessor<ServantMissionSettingsSingleton>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__ServantMissionSettingsAccessor));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__ServantMissionSettingsAccessor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServantMissionSettingsSingleton>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe int _LastQueriedEntityIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__LastQueriedEntityIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__LastQueriedEntityIndex)) = value;
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe BuffUtility.BuffSpawnerSystemData _BuffSpawnerSystemData
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__BuffSpawnerSystemData));
        return pointer == System.IntPtr.Zero ? (BuffUtility.BuffSpawnerSystemData) null : new BuffUtility.BuffSpawnerSystemData(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr__BuffSpawnerSystemData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __OnUpdate_LambdaJob0_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __OnUpdate_LambdaJob0_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___OnUpdate_LambdaJob0_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CheckIfAnyActiveMissionContainsServant_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___CheckIfAnyActiveMissionContainsServant_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___CheckIfAnyActiveMissionContainsServant_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CheckIfAnyActiveMissionContainsServant_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___CheckIfAnyActiveMissionContainsServant_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RemoveLingeringServantMissionBuffsSystem.NativeFieldInfoPtr___CheckIfAnyActiveMissionContainsServant_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.RemoveLingeringServantMissionBuffsSystem/<>c__DisplayClass7_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass7_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_lastQueriedEntityIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityToCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_isActuallyOnMission;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Int32_Entity_byref_ServantData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0;
      [FieldOffset(0)]
      public int lastQueriedEntityIndex;
      [FieldOffset(4)]
      public Entity entityToCheck;
      [FieldOffset(12)]
      public bool isActuallyOnMission;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass7_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        int entityInQueryIndex,
        Entity entity,
        [In] ref ServantData servantData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entityInQueryIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Int32_Entity_byref_ServantData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        [In] ref DynamicBuffer<ActiveServantMission> activeMissionBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeMissionBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass7_0()
      {
        Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, "<>c__DisplayClass7_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_lastQueriedEntityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (lastQueriedEntityIndex));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_entityToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (entityToCheck));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeFieldInfoPtr_isActuallyOnMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr, nameof (isActuallyOnMission));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr, 100669520);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Int32_Entity_byref_ServantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr, 100669521);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr, 100669522);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.RemoveLingeringServantMissionBuffsSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_OnUpdate_LambdaJob0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_lastQueriedEntityIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityToCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Int32_Entity_byref_ServantData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public int lastQueriedEntityIndex;
      [FieldOffset(4)]
      public Entity entityToCheck;
      [FieldOffset(16)]
      public RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1419619, RefRangeEnd = 1419620, XrefRangeStart = 1419619, XrefRangeEnd = 1419619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        int entityInQueryIndex,
        Entity entity,
        [In] ref ServantData servantData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entityInQueryIndex;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref servantData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Int32_Entity_byref_ServantData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(7)]
      [CachedScanResults(RefRangeStart = 1192585, RefRangeEnd = 1192592, XrefRangeStart = 1192585, XrefRangeEnd = 1192592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(11)]
      [CachedScanResults(RefRangeStart = 1192592, RefRangeEnd = 1192603, XrefRangeStart = 1192592, XrefRangeEnd = 1192603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419620, XrefRangeEnd = 1419622, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1419629, RefRangeEnd = 1419630, XrefRangeStart = 1419622, XrefRangeEnd = 1419629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1419632, RefRangeEnd = 1419633, XrefRangeStart = 1419630, XrefRangeEnd = 1419632, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RemoveLingeringServantMissionBuffsSystem componentSystem,
        ref RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419633, XrefRangeEnd = 1419637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419637, XrefRangeEnd = 1419643, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_OnUpdate_LambdaJob0()
      {
        Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, "<>c__DisplayClass_OnUpdate_LambdaJob0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_lastQueriedEntityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (lastQueriedEntityIndex));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_entityToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (entityToCheck));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (_runtimes));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Int32_Entity_byref_ServantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669523);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669524);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669525);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669526);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669527);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669528);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669529);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, 100669530);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entityInQueryIndex;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_servantData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_EntityInQueryIndex forParameter_entityInQueryIndex;
        [FieldOffset(4)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ServantData> forParameter_servantData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1419537, RefRangeEnd = 1419538, XrefRangeStart = 1419532, XrefRangeEnd = 1419537, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          RemoveLingeringServantMissionBuffsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1419543, RefRangeEnd = 1419544, XrefRangeStart = 1419538, XrefRangeEnd = 1419543, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entityInQueryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entityInQueryIndex));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_servantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_servantData));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100669531);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, 100669532);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entityInQueryIndex;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_servantData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_EntityInQueryIndex.Runtime runtime_entityInQueryIndex;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<ServantData>.Runtime runtime_servantData;

          static Runtimes()
          {
            Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entityInQueryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entityInQueryIndex));
            RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_servantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_servantData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.RemoveLingeringServantMissionBuffsSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000EC4$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000EC4$PostfixBurstDelegate");
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669533);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669534);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669535);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669536);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.RemoveLingeringServantMissionBuffsSystem/ProjectM.<>c__DisplayClass_OnUpdate_LambdaJob0/ProjectM.RunWithoutJobSystem_00000EC4$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419544, XrefRangeEnd = 1419558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419558, XrefRangeEnd = 1419576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419576, XrefRangeEnd = 1419591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1419618, RefRangeEnd = 1419619, XrefRangeStart = 1419591, XrefRangeEnd = 1419618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0>.NativeClassPtr, "RunWithoutJobSystem_00000EC4$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669537);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669538);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669539);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669540);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669542);
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
            IL2CPP.il2cpp_field_static_get_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_OnUpdate_LambdaJob0.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.RemoveLingeringServantMissionBuffsSystem/ProjectM.<>c__DisplayClass_CheckIfAnyActiveMissionContainsServant")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CheckIfAnyActiveMissionContainsServant
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityToCheck;
      private static readonly System.IntPtr NativeFieldInfoPtr_isActuallyOnMission;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_byref___c__DisplayClass7_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public Entity entityToCheck;
      [FieldOffset(8)]
      public bool isActuallyOnMission;
      [FieldOffset(16)]
      public RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419726, XrefRangeEnd = 1419736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        [In] ref DynamicBuffer<ActiveServantMission> activeMissionBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeMissionBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1419736, RefRangeEnd = 1419737, XrefRangeStart = 1419736, XrefRangeEnd = 1419736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1419737, RefRangeEnd = 1419738, XrefRangeStart = 1419737, XrefRangeEnd = 1419737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419738, XrefRangeEnd = 1419740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1419745, RefRangeEnd = 1419746, XrefRangeStart = 1419740, XrefRangeEnd = 1419745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1419748, RefRangeEnd = 1419749, XrefRangeStart = 1419746, XrefRangeEnd = 1419748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RemoveLingeringServantMissionBuffsSystem componentSystem,
        ref RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass7_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_byref___c__DisplayClass7_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419749, XrefRangeEnd = 1419753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419753, XrefRangeEnd = 1419759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CheckIfAnyActiveMissionContainsServant()
      {
        Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem>.NativeClassPtr, "<>c__DisplayClass_CheckIfAnyActiveMissionContainsServant");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr_entityToCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, nameof (entityToCheck));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr_isActuallyOnMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, nameof (isActuallyOnMission));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, nameof (_runtimes));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DynamicBuffer_1_ActiveServantMission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, 100669543);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, 100669544);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, 100669545);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, 100669546);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, 100669547);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_byref___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, 100669548);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, 100669549);
        RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, 100669550);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeMissionBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_DynamicBuffer<ActiveServantMission> forParameter_activeMissionBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1419646, RefRangeEnd = 1419647, XrefRangeStart = 1419643, XrefRangeEnd = 1419646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          RemoveLingeringServantMissionBuffsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1419650, RefRangeEnd = 1419651, XrefRangeStart = 1419647, XrefRangeEnd = 1419650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeMissionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeMissionBuffer));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RemoveLingeringServantMissionBuffsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders>.NativeClassPtr, 100669551);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders>.NativeClassPtr, 100669552);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeMissionBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_DynamicBuffer<ActiveServantMission>.Runtime runtime_activeMissionBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeMissionBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeMissionBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.RemoveLingeringServantMissionBuffsSystem/ProjectM.<>c__DisplayClass_CheckIfAnyActiveMissionContainsServant/ProjectM.RunWithoutJobSystem_00000ECD$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, "RunWithoutJobSystem_00000ECD$PostfixBurstDelegate");
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669553);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669554);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669555);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100669556);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.RemoveLingeringServantMissionBuffsSystem/ProjectM.<>c__DisplayClass_CheckIfAnyActiveMissionContainsServant/ProjectM.RunWithoutJobSystem_00000ECD$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419651, XrefRangeEnd = 1419665, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419665, XrefRangeEnd = 1419683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1419683, XrefRangeEnd = 1419698, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1419725, RefRangeEnd = 1419726, XrefRangeStart = 1419698, XrefRangeEnd = 1419725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant>.NativeClassPtr, "RunWithoutJobSystem_00000ECD$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669557);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669558);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669559);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669560);
          RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100669562);
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
            IL2CPP.il2cpp_field_static_get_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RemoveLingeringServantMissionBuffsSystem.__c__DisplayClass_CheckIfAnyActiveMissionContainsServant.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
