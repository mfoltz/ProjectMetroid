// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuffsTickSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class CastleBuffsTickSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__HealthChangeBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerBalanceSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr__ServerTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkRange;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr_TickTime;
    private static readonly System.IntPtr NativeFieldInfoPtr__DecayingCastleHearts;
    private static readonly System.IntPtr NativeFieldInfoPtr___ListDecayingCastleHearts_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ListDecayingCastleHearts_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForListDecayingCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190618, XrefRangeEnd = 1190657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuffsTickSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190657, XrefRangeEnd = 1190666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuffsTickSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190666, XrefRangeEnd = 1190718, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuffsTickSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuffsTickSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190718, XrefRangeEnd = 1190751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuffsTickSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190751, XrefRangeEnd = 1190767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForListDecayingCastleHearts_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.NativeMethodInfoPtr___GetEntityQuery_ForListDecayingCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190767, XrefRangeEnd = 1190771, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuffsTickSystem()
    {
      Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM", nameof (CastleBuffsTickSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr);
      CastleBuffsTickSystem.NativeFieldInfoPtr__HealthChangeBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, nameof (_HealthChangeBarrier));
      CastleBuffsTickSystem.NativeFieldInfoPtr__ServerBalanceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, nameof (_ServerBalanceSettings));
      CastleBuffsTickSystem.NativeFieldInfoPtr__ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, nameof (_ServerTime));
      CastleBuffsTickSystem.NativeFieldInfoPtr__ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, nameof (_ChunkRange));
      CastleBuffsTickSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, nameof (_Query));
      CastleBuffsTickSystem.NativeFieldInfoPtr_TickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, nameof (TickTime));
      CastleBuffsTickSystem.NativeFieldInfoPtr__DecayingCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, nameof (_DecayingCastleHearts));
      CastleBuffsTickSystem.NativeFieldInfoPtr___ListDecayingCastleHearts_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, "<>ListDecayingCastleHearts_entityQuery");
      CastleBuffsTickSystem.NativeFieldInfoPtr___ListDecayingCastleHearts_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, "<>ListDecayingCastleHearts_profilerMarker");
      CastleBuffsTickSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, 100663319);
      CastleBuffsTickSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, 100663320);
      CastleBuffsTickSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, 100663321);
      CastleBuffsTickSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, 100663322);
      CastleBuffsTickSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, 100663323);
      CastleBuffsTickSystem.NativeMethodInfoPtr___GetEntityQuery_ForListDecayingCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, 100663324);
      CastleBuffsTickSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, 100663325);
    }

    public CastleBuffsTickSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PostUpdateBarrier _HealthChangeBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__HealthChangeBarrier));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__HealthChangeBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SingletonAccessor<ServerGameBalanceSettings> _ServerBalanceSettings
    {
      get
      {
        return *(SingletonAccessor<ServerGameBalanceSettings>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__ServerBalanceSettings));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__ServerBalanceSettings), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerGameBalanceSettings>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe SingletonAccessor<ServerTime> _ServerTime
    {
      get
      {
        return *(SingletonAccessor<ServerTime>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__ServerTime));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__ServerTime), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<ServerTime>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe ChunkRange _ChunkRange
    {
      get
      {
        return *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__ChunkRange));
      }
      [param: In] set
      {
        *(ChunkRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__ChunkRange)) = value;
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe float TickTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr_TickTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr_TickTime)) = value;
      }
    }

    public unsafe NativeHashSet<Entity> _DecayingCastleHearts
    {
      get
      {
        return *(NativeHashSet<Entity>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__DecayingCastleHearts));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr__DecayingCastleHearts), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeHashSet<Entity>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __ListDecayingCastleHearts_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr___ListDecayingCastleHearts_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr___ListDecayingCastleHearts_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ListDecayingCastleHearts_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr___ListDecayingCastleHearts_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuffsTickSystem.NativeFieldInfoPtr___ListDecayingCastleHearts_profilerMarker)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ApplyDecayOrRegenJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DecayingCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DecayAndRegenType;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastleHeartConnectionType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EditableTileType;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntityType;
      private static readonly System.IntPtr NativeFieldInfoPtr_DecayModifier;
      private static readonly System.IntPtr NativeFieldInfoPtr_TickTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_ServerTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_HealthChangeCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunkRange;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStatChange_Private_Boolean_Entity_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_byref_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDecayDamage_Private_Boolean_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_TryGetDecayHealing_Private_Boolean_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> DecayingCastleHearts;
      [FieldOffset(16)]
      public ComponentTypeHandle<Health> HealthType;
      [FieldOffset(48)]
      public ComponentTypeHandle<CastleDecayAndRegen> DecayAndRegenType;
      [FieldOffset(80)]
      public ComponentTypeHandle<CastleHeartConnection> CastleHeartConnectionType;
      [FieldOffset(112)]
      public ComponentTypeHandle<EditableTileModel> EditableTileType;
      [FieldOffset(144)]
      public EntityTypeHandle EntityType;
      [FieldOffset(148)]
      public float DecayModifier;
      [FieldOffset(152)]
      public float TickTime;
      [FieldOffset(160)]
      public double ServerTime;
      [FieldOffset(168)]
      public EntityCommandBuffer HealthChangeCommandBuffer;
      [FieldOffset(184)]
      public ChunkRange ChunkRange;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190471, XrefRangeEnd = 1190490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1190498, RefRangeEnd = 1190499, XrefRangeStart = 1190490, XrefRangeEnd = 1190498, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetStatChange(
        Entity castleHeartEntity,
        [In] ref Health health,
        [In] ref CastleDecayAndRegen decayAndRegen,
        float timeSinceUpdated,
        out float healthChange,
        out int flags)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[6];
        numPtr[0] = (System.IntPtr) &castleHeartEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref health;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref decayAndRegen;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &timeSinceUpdated;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref healthChange;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) ref flags;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeMethodInfoPtr_TryGetStatChange_Private_Boolean_Entity_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_byref_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1190504, RefRangeEnd = 1190505, XrefRangeStart = 1190499, XrefRangeEnd = 1190504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetDecayDamage(
        [In] ref Health health,
        [In] ref CastleDecayAndRegen decayAndRegen,
        float ticksSinceUpdate,
        out float damage)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref health;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref decayAndRegen;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ticksSinceUpdate;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref damage;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeMethodInfoPtr_TryGetDecayDamage_Private_Boolean_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1190506, RefRangeEnd = 1190507, XrefRangeStart = 1190505, XrefRangeEnd = 1190506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool TryGetDecayHealing(
        [In] ref Health health,
        [In] ref CastleDecayAndRegen decayAndRegen,
        float ticksSinceUpdate,
        out float heal)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[4];
        numPtr[0] = (System.IntPtr) ref health;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref decayAndRegen;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &ticksSinceUpdate;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref heal;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeMethodInfoPtr_TryGetDecayHealing_Private_Boolean_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static ApplyDecayOrRegenJob()
      {
        Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, nameof (ApplyDecayOrRegenJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr);
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_DecayingCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (DecayingCastleHearts));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_HealthType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (HealthType));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_DecayAndRegenType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (DecayAndRegenType));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_CastleHeartConnectionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (CastleHeartConnectionType));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_EditableTileType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (EditableTileType));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_EntityType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (EntityType));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_DecayModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (DecayModifier));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_TickTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (TickTime));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_ServerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (ServerTime));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_HealthChangeCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (HealthChangeCommandBuffer));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeFieldInfoPtr_ChunkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, nameof (ChunkRange));
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, 100663326);
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeMethodInfoPtr_TryGetStatChange_Private_Boolean_Entity_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, 100663327);
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeMethodInfoPtr_TryGetDecayDamage_Private_Boolean_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, 100663328);
        CastleBuffsTickSystem.ApplyDecayOrRegenJob.NativeMethodInfoPtr_TryGetDecayHealing_Private_Boolean_byref_Health_byref_CastleDecayAndRegen_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, 100663329);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuffsTickSystem.ApplyDecayOrRegenJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuffsTickSystem/<>c__DisplayClass9_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass9_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_decayingCastleHearts;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Pylonstation_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> decayingCastleHearts;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass9_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref Pylonstation pylonstation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pylonstation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Pylonstation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass9_0()
      {
        Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, "<>c__DisplayClass9_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass9_0>.NativeClassPtr);
        CastleBuffsTickSystem.__c__DisplayClass9_0.NativeFieldInfoPtr_decayingCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass9_0>.NativeClassPtr, nameof (decayingCastleHearts));
        CastleBuffsTickSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663330);
        CastleBuffsTickSystem.__c__DisplayClass9_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_Pylonstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass9_0>.NativeClassPtr, 100663331);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass9_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuffsTickSystem/ProjectM.<>c__DisplayClass_ListDecayingCastleHearts")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ListDecayingCastleHearts
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_decayingCastleHearts;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuffsTickSystem_byref___c__DisplayClass9_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashSet<Entity> decayingCastleHearts;
      [FieldOffset(16)]
      public CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190592, XrefRangeEnd = 1190596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref Pylonstation pylonstation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref pylonstation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleBuffsTickSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleBuffsTickSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190596, XrefRangeEnd = 1190598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1190604, RefRangeEnd = 1190605, XrefRangeStart = 1190598, XrefRangeEnd = 1190604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1190607, RefRangeEnd = 1190608, XrefRangeStart = 1190605, XrefRangeEnd = 1190607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleBuffsTickSystem componentSystem,
        ref CastleBuffsTickSystem.__c__DisplayClass9_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuffsTickSystem_byref___c__DisplayClass9_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190608, XrefRangeEnd = 1190612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190612, XrefRangeEnd = 1190618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ListDecayingCastleHearts()
      {
        Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuffsTickSystem>.NativeClassPtr, "<>c__DisplayClass_ListDecayingCastleHearts");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr);
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr_decayingCastleHearts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, nameof (decayingCastleHearts));
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, nameof (_runtimes));
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_Pylonstation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, 100663332);
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, 100663333);
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, 100663334);
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, 100663335);
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, 100663336);
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuffsTickSystem_byref___c__DisplayClass9_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, 100663337);
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, 100663338);
        CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, 100663339);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_pylonstation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuffsTickSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Pylonstation> forParameter_pylonstation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1190511, RefRangeEnd = 1190512, XrefRangeStart = 1190507, XrefRangeEnd = 1190511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleBuffsTickSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuffsTickSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1190516, RefRangeEnd = 1190517, XrefRangeStart = 1190512, XrefRangeEnd = 1190516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_pylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_pylonstation));
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuffsTickSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100663340);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100663341);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_pylonstation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Pylonstation>.Runtime runtime_pylonstation;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_pylonstation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_pylonstation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuffsTickSystem/ProjectM.<>c__DisplayClass_ListDecayingCastleHearts/ProjectM.RunWithoutJobSystem_00000029$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_00000029$PostfixBurstDelegate");
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663342);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663343);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663344);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663345);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuffsTickSystem/ProjectM.<>c__DisplayClass_ListDecayingCastleHearts/ProjectM.RunWithoutJobSystem_00000029$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190517, XrefRangeEnd = 1190531, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190531, XrefRangeEnd = 1190549, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190549, XrefRangeEnd = 1190564, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1190591, RefRangeEnd = 1190592, XrefRangeStart = 1190564, XrefRangeEnd = 1190591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_00000029$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663346);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663347);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663348);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663349);
          CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663351);
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
            IL2CPP.il2cpp_field_static_get_value(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleBuffsTickSystem.__c__DisplayClass_ListDecayingCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
