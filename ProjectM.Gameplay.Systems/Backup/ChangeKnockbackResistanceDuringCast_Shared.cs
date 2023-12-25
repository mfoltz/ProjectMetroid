// Decompiled with JetBrains decompiler
// Type: ProjectM.ChangeKnockbackResistanceDuringCast_Shared
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class ChangeKnockbackResistanceDuringCast_Shared : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateChangeKnockbackResistanceDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CreateChangeKnockbackResistanceDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveChangeKnockbackResistanceDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveChangeKnockbackResistanceDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableModification_Public_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCreateChangeKnockbackResistanceDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveChangeKnockbackResistanceDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373468, XrefRangeEnd = 1373474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373474, XrefRangeEnd = 1373509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1373533, RefRangeEnd = 1373535, XrefRangeStart = 1373509, XrefRangeEnd = 1373533, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DisableModification(
      EntityManager entityManager,
      Entity abilityEntity,
      Entity characterEntity)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entityManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &abilityEntity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &characterEntity;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_DisableModification_Public_Static_Void_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChangeKnockbackResistanceDuringCast_Shared()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373535, XrefRangeEnd = 1373599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373599, XrefRangeEnd = 1373615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCreateChangeKnockbackResistanceDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr___GetEntityQuery_ForCreateChangeKnockbackResistanceDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373615, XrefRangeEnd = 1373631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveChangeKnockbackResistanceDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr___GetEntityQuery_ForRemoveChangeKnockbackResistanceDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1373635, RefRangeEnd = 1373636, XrefRangeStart = 1373631, XrefRangeEnd = 1373635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1373640, RefRangeEnd = 1373641, XrefRangeStart = 1373636, XrefRangeEnd = 1373640, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChangeKnockbackResistanceDuringCast_Shared()
    {
      Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (ChangeKnockbackResistanceDuringCast_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr);
      ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, nameof (_ModificationSystem));
      ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___CreateChangeKnockbackResistanceDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, "<>CreateChangeKnockbackResistanceDuringCast_entityQuery");
      ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___CreateChangeKnockbackResistanceDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, "<>CreateChangeKnockbackResistanceDuringCast_profilerMarker");
      ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___RemoveChangeKnockbackResistanceDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, "<>RemoveChangeKnockbackResistanceDuringCast_entityQuery");
      ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___RemoveChangeKnockbackResistanceDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, "<>RemoveChangeKnockbackResistanceDuringCast_profilerMarker");
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664483);
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664484);
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_DisableModification_Public_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664485);
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664486);
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664487);
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr___GetEntityQuery_ForCreateChangeKnockbackResistanceDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664488);
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr___GetEntityQuery_ForRemoveChangeKnockbackResistanceDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664489);
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664490);
      ChangeKnockbackResistanceDuringCast_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, 100664491);
    }

    public ChangeKnockbackResistanceDuringCast_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __CreateChangeKnockbackResistanceDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___CreateChangeKnockbackResistanceDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___CreateChangeKnockbackResistanceDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CreateChangeKnockbackResistanceDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___CreateChangeKnockbackResistanceDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___CreateChangeKnockbackResistanceDuringCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RemoveChangeKnockbackResistanceDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___RemoveChangeKnockbackResistanceDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___RemoveChangeKnockbackResistanceDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveChangeKnockbackResistanceDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___RemoveChangeKnockbackResistanceDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.NativeFieldInfoPtr___RemoveChangeKnockbackResistanceDuringCast_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_Shared/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_getKnockbackResistanceModification;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityPreCastEndedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1([In] ref AbilityPreCastEndedEvent abilityCastEndedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref abilityCastEndedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityPreCastEndedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_getKnockbackResistanceModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, nameof (getKnockbackResistanceModification));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, nameof (modificationStruct));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, nameof (entityManager));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100664492);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100664493);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityPreCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100664494);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe ChangeKnockbackResistanceDuringCast_Shared __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ChangeKnockbackResistanceDuringCast_Shared) null : new ChangeKnockbackResistanceDuringCast_Shared(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BufferFromEntity<IntModificationBuffer> getKnockbackResistanceModification
      {
        get
        {
          return *(BufferFromEntity<IntModificationBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_getKnockbackResistanceModification));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_getKnockbackResistanceModification), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<IntModificationBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ModificationStructure modificationStruct
      {
        get
        {
          return *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct));
        }
        [param: In] set
        {
          *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_Shared/ProjectM.<>c__DisplayClass_CreateChangeKnockbackResistanceDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CreateChangeKnockbackResistanceDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getKnockbackResistanceModification;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_ChangeKnockbackResistanceDuringCast_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Buffable_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BufferFromEntity<IntModificationBuffer> getKnockbackResistanceModification;
      [FieldOffset(40)]
      public ModificationStructure modificationStruct;
      [FieldOffset(72)]
      public ComponentDataFromEntity<ChangeKnockbackResistanceDuringCast> _ComponentDataFromEntity_ChangeKnockbackResistanceDuringCast_0;
      [FieldOffset(104)]
      public ComponentDataFromEntity<Buffable> _ComponentDataFromEntity_Buffable_1;
      [FieldOffset(136)]
      public ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(168)]
      public unsafe ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373312, XrefRangeEnd = 1373333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373333, RefRangeEnd = 1373334, XrefRangeStart = 1373333, XrefRangeEnd = 1373333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373334, RefRangeEnd = 1373335, XrefRangeStart = 1373334, XrefRangeEnd = 1373334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373335, XrefRangeEnd = 1373337, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373342, RefRangeEnd = 1373343, XrefRangeStart = 1373337, XrefRangeEnd = 1373342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373351, RefRangeEnd = 1373352, XrefRangeStart = 1373343, XrefRangeEnd = 1373351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ChangeKnockbackResistanceDuringCast_Shared componentSystem,
        ref ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373352, XrefRangeEnd = 1373356, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373356, XrefRangeEnd = 1373362, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CreateChangeKnockbackResistanceDuringCast()
      {
        Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, "<>c__DisplayClass_CreateChangeKnockbackResistanceDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_getKnockbackResistanceModification = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (getKnockbackResistanceModification));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (modificationStruct));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_ChangeKnockbackResistanceDuringCast_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_ChangeKnockbackResistanceDuringCast_0));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_Buffable_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_Buffable_1));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (_runtimes));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664495);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664496);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664497);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664498);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664499);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664500);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664501);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664502);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castStartedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent> forParameter_castStartedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373232, RefRangeEnd = 1373233, XrefRangeStart = 1373229, XrefRangeEnd = 1373232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          ChangeKnockbackResistanceDuringCast_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373236, RefRangeEnd = 1373237, XrefRangeStart = 1373233, XrefRangeEnd = 1373236, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castStartedEvent));
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100664503);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100664504);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castStartedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent>.Runtime runtime_castStartedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castStartedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_Shared/ProjectM.<>c__DisplayClass_CreateChangeKnockbackResistanceDuringCast/ProjectM.RunWithoutJobSystem_000002D3$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, "RunWithoutJobSystem_000002D3$PostfixBurstDelegate");
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664505);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664506);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664507);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664508);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_Shared/ProjectM.<>c__DisplayClass_CreateChangeKnockbackResistanceDuringCast/ProjectM.RunWithoutJobSystem_000002D3$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373237, XrefRangeEnd = 1373251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373251, XrefRangeEnd = 1373269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373269, XrefRangeEnd = 1373284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373311, RefRangeEnd = 1373312, XrefRangeStart = 1373284, XrefRangeEnd = 1373311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast>.NativeClassPtr, "RunWithoutJobSystem_000002D3$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664509);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664510);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664511);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664512);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664514);
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
            IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_CreateChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_Shared/ProjectM.<>c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityPreCastEndedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373446, RefRangeEnd = 1373447, XrefRangeStart = 1373445, XrefRangeEnd = 1373446, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityPreCastEndedEvent abilityCastEndedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref abilityCastEndedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityPreCastEndedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1355950, RefRangeEnd = 1355952, XrefRangeStart = 1355950, XrefRangeEnd = 1355952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1355952, RefRangeEnd = 1355954, XrefRangeStart = 1355952, XrefRangeEnd = 1355954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373447, XrefRangeEnd = 1373449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373454, RefRangeEnd = 1373455, XrefRangeStart = 1373449, XrefRangeEnd = 1373454, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1373457, RefRangeEnd = 1373458, XrefRangeStart = 1373455, XrefRangeEnd = 1373457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ChangeKnockbackResistanceDuringCast_Shared componentSystem,
        ref ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373458, XrefRangeEnd = 1373462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373462, XrefRangeEnd = 1373468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast()
      {
        Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared>.NativeClassPtr, "<>c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (entityManager));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (_runtimes));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityPreCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664515);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664516);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664517);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664518);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664519);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664520);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664521);
        ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, 100664522);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_abilityCastEndedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityPreCastEndedEvent> forParameter_abilityCastEndedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373365, RefRangeEnd = 1373366, XrefRangeStart = 1373362, XrefRangeEnd = 1373365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          ChangeKnockbackResistanceDuringCast_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373369, RefRangeEnd = 1373370, XrefRangeStart = 1373366, XrefRangeEnd = 1373369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_abilityCastEndedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_abilityCastEndedEvent));
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ChangeKnockbackResistanceDuringCast_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100664523);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100664524);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_abilityCastEndedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityPreCastEndedEvent>.Runtime runtime_abilityCastEndedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_abilityCastEndedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_abilityCastEndedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_Shared/ProjectM.<>c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast/ProjectM.RunWithoutJobSystem_000002DC$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, "RunWithoutJobSystem_000002DC$PostfixBurstDelegate");
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664525);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664526);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664527);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664528);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ChangeKnockbackResistanceDuringCast_Shared/ProjectM.<>c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast/ProjectM.RunWithoutJobSystem_000002DC$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373370, XrefRangeEnd = 1373384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373384, XrefRangeEnd = 1373402, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1373402, XrefRangeEnd = 1373417, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1373444, RefRangeEnd = 1373445, XrefRangeStart = 1373417, XrefRangeEnd = 1373444, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast>.NativeClassPtr, "RunWithoutJobSystem_000002DC$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664529);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664530);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664531);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664532);
          ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664534);
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
            IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ChangeKnockbackResistanceDuringCast_Shared.__c__DisplayClass_RemoveChangeKnockbackResistanceDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
