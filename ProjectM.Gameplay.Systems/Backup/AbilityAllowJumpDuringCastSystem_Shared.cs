// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityAllowJumpDuringCastSystem_Shared
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
  public class AbilityAllowJumpDuringCastSystem_Shared : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ModificationSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddAllowJumpDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___AddAllowJumpDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveAllowJumpDuringCast_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveAllowJumpDuringCast_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForAddAllowJumpDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveAllowJumpDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364885, XrefRangeEnd = 1364891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364891, XrefRangeEnd = 1364922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityAllowJumpDuringCastSystem_Shared()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364922, XrefRangeEnd = 1364986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364986, XrefRangeEnd = 1365002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForAddAllowJumpDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForAddAllowJumpDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365002, XrefRangeEnd = 1365018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveAllowJumpDuringCast_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForRemoveAllowJumpDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365018, XrefRangeEnd = 1365022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1365022, XrefRangeEnd = 1365026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityAllowJumpDuringCastSystem_Shared()
    {
      Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (AbilityAllowJumpDuringCastSystem_Shared));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr);
      AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr__ModificationSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, nameof (_ModificationSystem));
      AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___AddAllowJumpDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, "<>AddAllowJumpDuringCast_entityQuery");
      AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___AddAllowJumpDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, "<>AddAllowJumpDuringCast_profilerMarker");
      AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveAllowJumpDuringCast_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, "<>RemoveAllowJumpDuringCast_entityQuery");
      AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveAllowJumpDuringCast_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, "<>RemoveAllowJumpDuringCast_profilerMarker");
      AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, 100663760);
      AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, 100663761);
      AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, 100663762);
      AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, 100663763);
      AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForAddAllowJumpDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, 100663764);
      AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr___GetEntityQuery_ForRemoveAllowJumpDuringCast_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, 100663765);
      AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, 100663766);
      AbilityAllowJumpDuringCastSystem_Shared.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, 100663767);
    }

    public AbilityAllowJumpDuringCastSystem_Shared(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModificationSystem _ModificationSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr__ModificationSystem));
        return pointer == System.IntPtr.Zero ? (ModificationSystem) null : new ModificationSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr__ModificationSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __AddAllowJumpDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___AddAllowJumpDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___AddAllowJumpDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __AddAllowJumpDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___AddAllowJumpDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___AddAllowJumpDuringCast_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RemoveAllowJumpDuringCast_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveAllowJumpDuringCast_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveAllowJumpDuringCast_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveAllowJumpDuringCast_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveAllowJumpDuringCast_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.NativeFieldInfoPtr___RemoveAllowJumpDuringCast_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.AbilityAllowJumpDuringCastSystem_Shared/<>c__DisplayClass2_0")]
    public sealed class __c__DisplayClass2_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityCastEndedEvent_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
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
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1([In] ref AbilityCastEndedEvent castEnded)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castEnded;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityCastEndedEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, "<>4__this");
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, nameof (modificationStruct));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100663768);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100663769);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_byref_AbilityCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, 100663770);
      }

      public __c__DisplayClass2_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass2_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0>.NativeClassPtr, data));
      }

      public unsafe AbilityAllowJumpDuringCastSystem_Shared __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AbilityAllowJumpDuringCastSystem_Shared) null : new AbilityAllowJumpDuringCastSystem_Shared(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ModificationStructure modificationStruct
      {
        get
        {
          return *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct));
        }
        [param: In] set
        {
          *(ModificationStructure*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0.NativeFieldInfoPtr_modificationStruct)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityAllowJumpDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_AddAllowJumpDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_AddAllowJumpDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_modificationStruct;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AllowJumpDuringCast_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_JumpFromCliffs_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BoolModificationBuffer_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ModificationStructure modificationStruct;
      [FieldOffset(32)]
      public ComponentDataFromEntity<AllowJumpDuringCast> _ComponentDataFromEntity_AllowJumpDuringCast_0;
      [FieldOffset(64)]
      public ComponentDataFromEntity<JumpFromCliffs> _ComponentDataFromEntity_JumpFromCliffs_1;
      [FieldOffset(96)]
      public BufferFromEntity<BoolModificationBuffer> _BufferFromEntity_BoolModificationBuffer_2;
      [FieldOffset(136)]
      public AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(168)]
      public unsafe AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364684, XrefRangeEnd = 1364712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityCastStartedEvent castStartedEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castStartedEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1364712, RefRangeEnd = 1364715, XrefRangeStart = 1364712, XrefRangeEnd = 1364712, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1364715, RefRangeEnd = 1364718, XrefRangeStart = 1364715, XrefRangeEnd = 1364715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364718, XrefRangeEnd = 1364720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1364725, RefRangeEnd = 1364726, XrefRangeStart = 1364720, XrefRangeEnd = 1364725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1364737, RefRangeEnd = 1364738, XrefRangeStart = 1364726, XrefRangeEnd = 1364737, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityAllowJumpDuringCastSystem_Shared componentSystem,
        ref AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364738, XrefRangeEnd = 1364742, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364742, XrefRangeEnd = 1364748, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_AddAllowJumpDuringCast()
      {
        Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_AddAllowJumpDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr_modificationStruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (modificationStruct));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_AllowJumpDuringCast_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AllowJumpDuringCast_0));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_JumpFromCliffs_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_JumpFromCliffs_1));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr__BufferFromEntity_BoolModificationBuffer_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (_BufferFromEntity_BoolModificationBuffer_2));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (_runtimes));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastStartedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, 100663771);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, 100663772);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, 100663773);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, 100663774);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, 100663775);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, 100663776);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, 100663777);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, 100663778);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castStartedEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent> forParameter_castStartedEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364604, RefRangeEnd = 1364605, XrefRangeStart = 1364601, XrefRangeEnd = 1364604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityAllowJumpDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364608, RefRangeEnd = 1364609, XrefRangeStart = 1364605, XrefRangeEnd = 1364608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castStartedEvent));
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663779);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663780);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castStartedEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastStartedEvent>.Runtime runtime_castStartedEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castStartedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castStartedEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityAllowJumpDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_AddAllowJumpDuringCast/ProjectM.RunWithoutJobSystem_00000113$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, "RunWithoutJobSystem_00000113$PostfixBurstDelegate");
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663781);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663782);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663783);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663784);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityAllowJumpDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_AddAllowJumpDuringCast/ProjectM.RunWithoutJobSystem_00000113$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364609, XrefRangeEnd = 1364623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364623, XrefRangeEnd = 1364641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364641, XrefRangeEnd = 1364656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364683, RefRangeEnd = 1364684, XrefRangeStart = 1364656, XrefRangeEnd = 1364683, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast>.NativeClassPtr, "RunWithoutJobSystem_00000113$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663785);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663786);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663787);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663788);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663790);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_AddAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.AbilityAllowJumpDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveAllowJumpDuringCast")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RemoveAllowJumpDuringCast
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_AllowJumpDuringCast_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_JumpFromCliffs_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__BufferFromEntity_BoolModificationBuffer_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastEndedEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<AllowJumpDuringCast> _ComponentDataFromEntity_AllowJumpDuringCast_0;
      [FieldOffset(32)]
      public ComponentDataFromEntity<JumpFromCliffs> _ComponentDataFromEntity_JumpFromCliffs_1;
      [FieldOffset(64)]
      public BufferFromEntity<BoolModificationBuffer> _BufferFromEntity_BoolModificationBuffer_2;
      [FieldOffset(104)]
      public AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(136)]
      public unsafe AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364831, XrefRangeEnd = 1364856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref AbilityCastEndedEvent castEnded)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref castEnded;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastEndedEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364856, XrefRangeEnd = 1364858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1364863, RefRangeEnd = 1364864, XrefRangeStart = 1364858, XrefRangeEnd = 1364863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1364874, RefRangeEnd = 1364875, XrefRangeStart = 1364864, XrefRangeEnd = 1364874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AbilityAllowJumpDuringCastSystem_Shared componentSystem,
        ref AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364875, XrefRangeEnd = 1364879, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364879, XrefRangeEnd = 1364885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveAllowJumpDuringCast()
      {
        Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared>.NativeClassPtr, "<>c__DisplayClass_RemoveAllowJumpDuringCast");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_AllowJumpDuringCast_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_AllowJumpDuringCast_0));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr__ComponentDataFromEntity_JumpFromCliffs_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, nameof (_ComponentDataFromEntity_JumpFromCliffs_1));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr__BufferFromEntity_BoolModificationBuffer_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, nameof (_BufferFromEntity_BoolModificationBuffer_2));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, nameof (_runtimes));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_AbilityCastEndedEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, 100663791);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, 100663792);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, 100663793);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, 100663794);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, 100663795);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, 100663796);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, 100663797);
        AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, 100663798);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castEnded;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<AbilityCastEndedEvent> forParameter_castEnded;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364751, RefRangeEnd = 1364752, XrefRangeStart = 1364748, XrefRangeEnd = 1364751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          AbilityAllowJumpDuringCastSystem_Shared componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364755, RefRangeEnd = 1364756, XrefRangeStart = 1364752, XrefRangeEnd = 1364755, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castEnded));
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AbilityAllowJumpDuringCastSystem_Shared_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663799);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, 100663800);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castEnded;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<AbilityCastEndedEvent>.Runtime runtime_castEnded;

          static Runtimes()
          {
            Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castEnded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castEnded));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.AbilityAllowJumpDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveAllowJumpDuringCast/ProjectM.RunWithoutJobSystem_0000011C$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, "RunWithoutJobSystem_0000011C$PostfixBurstDelegate");
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663801);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663802);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663803);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663804);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.AbilityAllowJumpDuringCastSystem_Shared/ProjectM.<>c__DisplayClass_RemoveAllowJumpDuringCast/ProjectM.RunWithoutJobSystem_0000011C$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364756, XrefRangeEnd = 1364770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364770, XrefRangeEnd = 1364788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1364788, XrefRangeEnd = 1364803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1364830, RefRangeEnd = 1364831, XrefRangeStart = 1364803, XrefRangeEnd = 1364830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast>.NativeClassPtr, "RunWithoutJobSystem_0000011C$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663805);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663806);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663807);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663808);
          AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663810);
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
            IL2CPP.il2cpp_field_static_get_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AbilityAllowJumpDuringCastSystem_Shared.__c__DisplayClass_RemoveAllowJumpDuringCast.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
