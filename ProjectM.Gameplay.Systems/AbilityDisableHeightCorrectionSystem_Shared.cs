// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityDisableHeightCorrectionSystem_Shared
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
  public class AbilityDisableHeightCorrectionSystem_Shared : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Start_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Start_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Stop_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Stop_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DisableModification_Public_Static_Void_EntityManager_Entity_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDisableHeightCorrectionDuringCast_Start_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDisableHeightCorrectionDuringCast_Stop_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368009, XrefRangeEnd = 1368015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368015, XrefRangeEnd = 1368054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1368078, RefRangeEnd = 1368080, XrefRangeStart = 1368054, XrefRangeEnd = 1368078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_DisableModification_Public_Static_Void_EntityManager_Entity_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityDisableHeightCorrectionSystem_Shared()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368080, XrefRangeEnd = 1368144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368144, XrefRangeEnd = 1368160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDisableHeightCorrectionDuringCast_Start_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForDisableHeightCorrectionDuringCast_Start_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368160, XrefRangeEnd = 1368176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDisableHeightCorrectionDuringCast_Stop_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForDisableHeightCorrectionDuringCast_Stop_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368176, XrefRangeEnd = 1368180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368180, XrefRangeEnd = 1368184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityDisableHeightCorrectionSystem_Shared()
    {
      Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityDisableHeightCorrectionSystem_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr);
      AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, nameof (_ModificationSystem));
      AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Start_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, "<>DisableHeightCorrectionDuringCast_Start_entityQuery");
      AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Start_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, "<>DisableHeightCorrectionDuringCast_Start_profilerMarker");
      AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Stop_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, "<>DisableHeightCorrectionDuringCast_Stop_entityQuery");
      AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Stop_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, "<>DisableHeightCorrectionDuringCast_Stop_profilerMarker");
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664125);
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664126);
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_DisableModification_Public_Static_Void_EntityManager_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664127);
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664128);
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664129);
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForDisableHeightCorrectionDuringCast_Start_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664130);
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForDisableHeightCorrectionDuringCast_Stop_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664131);
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664132);
      AbilityDisableHeightCorrectionSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, 100664133);
    }

    public AbilityDisableHeightCorrectionSystem_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __DisableHeightCorrectionDuringCast_Start_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Start_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Start_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DisableHeightCorrectionDuringCast_Start_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Start_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Start_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __DisableHeightCorrectionDuringCast_Stop_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Stop_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Stop_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DisableHeightCorrectionDuringCast_Stop_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Stop_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.NativeFieldInfoPtr___DisableHeightCorrectionDuringCast_Stop_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AbilityDisableHeightCorrectionSystem_Shared/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_getLongModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityPreCastEndedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1([In] ref AbilityPreCastEndedEvent castEndedEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castEndedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityPreCastEndedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_getLongModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, nameof (getLongModifications));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, nameof (modificationStruct));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, nameof (commandBuffer));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, nameof (entityManager));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100664134);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100664135);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityPreCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100664136);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe AbilityDisableHeightCorrectionSystem_Shared __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AbilityDisableHeightCorrectionSystem_Shared) null : new AbilityDisableHeightCorrectionSystem_Shared(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe BufferFromEntity<LongModificationBuffer> getLongModifications
      {
        get
        {
          return *(BufferFromEntity<LongModificationBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_getLongModifications));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_getLongModifications), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<LongModificationBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe ModificationStructure modificationStruct
      {
        get
        {
          return *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct));
        }
        [param: In] set
        {
          *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityDisableHeightCorrectionSystem_Shared/ProjectM.<>c__DisplayClass_DisableHeightCorrectionDuringCast_Start")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DisableHeightCorrectionDuringCast_Start
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getLongModifications;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_DisableHeightCorrectionDuringCast_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BufferFromEntity<LongModificationBuffer> getLongModifications;
      [FieldOffset(40)]
      public ModificationStructure modificationStruct;
      [FieldOffset(72)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(88)]
      public ComponentDataFromEntity<DisableHeightCorrectionDuringCast> _ComponentDataFromEntity_DisableHeightCorrectionDuringCast_0;
      [FieldOffset(120)]
      public ComponentDataFromEntity<BuffableFlagState> _ComponentDataFromEntity_BuffableFlagState_1;
      [FieldOffset(152)]
      public AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(184)]
      public unsafe AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367836, XrefRangeEnd = 1367857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1367857, RefRangeEnd = 1367859, XrefRangeStart = 1367857, XrefRangeEnd = 1367857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1367859, RefRangeEnd = 1367861, XrefRangeStart = 1367859, XrefRangeEnd = 1367859, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367861, XrefRangeEnd = 1367863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367868, RefRangeEnd = 1367869, XrefRangeStart = 1367863, XrefRangeEnd = 1367868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367877, RefRangeEnd = 1367878, XrefRangeStart = 1367869, XrefRangeEnd = 1367877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityDisableHeightCorrectionSystem_Shared componentSystem,
        ref AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367878, XrefRangeEnd = 1367882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367882, XrefRangeEnd = 1367888, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DisableHeightCorrectionDuringCast_Start()
      {
        Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_DisableHeightCorrectionDuringCast_Start");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_getLongModifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (getLongModifications));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (modificationStruct));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (commandBuffer));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr__ComponentDataFromEntity_DisableHeightCorrectionDuringCast_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (_ComponentDataFromEntity_DisableHeightCorrectionDuringCast_0));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr__ComponentDataFromEntity_BuffableFlagState_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (_ComponentDataFromEntity_BuffableFlagState_1));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (_runtimes));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, 100664137);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, 100664138);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, 100664139);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, 100664140);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, 100664141);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, 100664142);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, 100664143);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, 100664144);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castStartedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent> forParameter_castStartedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1367756, RefRangeEnd = 1367757, XrefRangeStart = 1367753, XrefRangeEnd = 1367756, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityDisableHeightCorrectionSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1367760, RefRangeEnd = 1367761, XrefRangeStart = 1367757, XrefRangeEnd = 1367760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castStartedEvent));
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders>.NativeClassPtr, 100664145);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders>.NativeClassPtr, 100664146);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castStartedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent>.Runtime runtime_castStartedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castStartedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityDisableHeightCorrectionSystem_Shared/ProjectM.<>c__DisplayClass_DisableHeightCorrectionDuringCast_Start/ProjectM.RunWithoutJobSystem_000001D9$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, "RunWithoutJobSystem_000001D9$PostfixBurstDelegate");
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664147);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664148);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664149);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664150);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityDisableHeightCorrectionSystem_Shared/ProjectM.<>c__DisplayClass_DisableHeightCorrectionDuringCast_Start/ProjectM.RunWithoutJobSystem_000001D9$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367761, XrefRangeEnd = 1367775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367775, XrefRangeEnd = 1367793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367793, XrefRangeEnd = 1367808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1367835, RefRangeEnd = 1367836, XrefRangeStart = 1367808, XrefRangeEnd = 1367835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start>.NativeClassPtr, "RunWithoutJobSystem_000001D9$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664151);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664152);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664153);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664154);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664156);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Start.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityDisableHeightCorrectionSystem_Shared/ProjectM.<>c__DisplayClass_DisableHeightCorrectionDuringCast_Stop")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DisableHeightCorrectionDuringCast_Stop
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
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(40)]
      public unsafe AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367985, RefRangeEnd = 1367986, XrefRangeStart = 1367971, XrefRangeEnd = 1367985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityPreCastEndedEvent castEndedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castEndedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityPreCastEndedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367986, RefRangeEnd = 1367987, XrefRangeStart = 1367986, XrefRangeEnd = 1367986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367987, RefRangeEnd = 1367988, XrefRangeStart = 1367987, XrefRangeEnd = 1367987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367988, XrefRangeEnd = 1367990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367995, RefRangeEnd = 1367996, XrefRangeStart = 1367990, XrefRangeEnd = 1367995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1367998, RefRangeEnd = 1367999, XrefRangeStart = 1367996, XrefRangeEnd = 1367998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityDisableHeightCorrectionSystem_Shared componentSystem,
        ref AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367999, XrefRangeEnd = 1368003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1368003, XrefRangeEnd = 1368009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DisableHeightCorrectionDuringCast_Stop()
      {
        Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_DisableHeightCorrectionDuringCast_Stop");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, nameof (entityManager));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, nameof (_runtimes));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityPreCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, 100664157);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, 100664158);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, 100664159);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, 100664160);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, 100664161);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, 100664162);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, 100664163);
        AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, 100664164);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castEndedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityPreCastEndedEvent> forParameter_castEndedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1367891, RefRangeEnd = 1367892, XrefRangeStart = 1367888, XrefRangeEnd = 1367891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityDisableHeightCorrectionSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1367895, RefRangeEnd = 1367896, XrefRangeStart = 1367892, XrefRangeEnd = 1367895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castEndedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castEndedEvent));
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityDisableHeightCorrectionSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders>.NativeClassPtr, 100664165);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders>.NativeClassPtr, 100664166);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castEndedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityPreCastEndedEvent>.Runtime runtime_castEndedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castEndedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castEndedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityDisableHeightCorrectionSystem_Shared/ProjectM.<>c__DisplayClass_DisableHeightCorrectionDuringCast_Stop/ProjectM.RunWithoutJobSystem_000001E2$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, "RunWithoutJobSystem_000001E2$PostfixBurstDelegate");
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664167);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664168);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664169);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664170);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityDisableHeightCorrectionSystem_Shared/ProjectM.<>c__DisplayClass_DisableHeightCorrectionDuringCast_Stop/ProjectM.RunWithoutJobSystem_000001E2$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367896, XrefRangeEnd = 1367910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367910, XrefRangeEnd = 1367928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1367928, XrefRangeEnd = 1367943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1367970, RefRangeEnd = 1367971, XrefRangeStart = 1367943, XrefRangeEnd = 1367970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop>.NativeClassPtr, "RunWithoutJobSystem_000001E2$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664171);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664172);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664173);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664174);
          AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664176);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityDisableHeightCorrectionSystem_Shared.__c__DisplayClass_DisableHeightCorrectionDuringCast_Stop.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
