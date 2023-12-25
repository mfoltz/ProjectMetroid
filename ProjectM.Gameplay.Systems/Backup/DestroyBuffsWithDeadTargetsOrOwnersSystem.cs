// Decompiled with JetBrains decompiler
// Type: ProjectM.DestroyBuffsWithDeadTargetsOrOwnersSystem
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
  public class DestroyBuffsWithDeadTargetsOrOwnersSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr__DeathEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DestroyBuffsWithDeadTargets_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DestroyBuffsWithDeadTargets_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___DestroyBuffsWithDeadOwners_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DestroyBuffsWithDeadOwners_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDestroyBuffsWithDeadTargets_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDestroyBuffsWithDeadOwners_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376817, XrefRangeEnd = 1376823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376823, XrefRangeEnd = 1376856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyBuffsWithDeadTargetsOrOwnersSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376856, XrefRangeEnd = 1376923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376923, XrefRangeEnd = 1376939, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDestroyBuffsWithDeadTargets_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroyBuffsWithDeadTargets_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376939, XrefRangeEnd = 1376958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDestroyBuffsWithDeadOwners_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroyBuffsWithDeadOwners_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1376962, RefRangeEnd = 1376963, XrefRangeStart = 1376958, XrefRangeEnd = 1376962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1376967, RefRangeEnd = 1376968, XrefRangeStart = 1376963, XrefRangeEnd = 1376967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyBuffsWithDeadTargetsOrOwnersSystem()
    {
      Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (DestroyBuffsWithDeadTargetsOrOwnersSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr);
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr__DestroyBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, nameof (_DestroyBarrier));
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr__DeathEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, nameof (_DeathEventQuery));
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadTargets_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, "<>DestroyBuffsWithDeadTargets_entityQuery");
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadTargets_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, "<>DestroyBuffsWithDeadTargets_profilerMarker");
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadOwners_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, "<>DestroyBuffsWithDeadOwners_entityQuery");
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadOwners_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, "<>DestroyBuffsWithDeadOwners_profilerMarker");
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, 100664884);
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, 100664885);
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, 100664886);
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, 100664887);
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroyBuffsWithDeadTargets_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, 100664888);
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroyBuffsWithDeadOwners_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, 100664889);
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, 100664890);
      DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeMethodInfoPtr_Method_Public_Static_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, 100664891);
    }

    public DestroyBuffsWithDeadTargetsOrOwnersSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe DestroyBarrier _DestroyBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr__DestroyBarrier));
        return pointer == System.IntPtr.Zero ? (DestroyBarrier) null : new DestroyBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr__DestroyBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DeathEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr__DeathEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr__DeathEventQuery)) = value;
      }
    }

    public unsafe EntityQuery __DestroyBuffsWithDeadTargets_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadTargets_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadTargets_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DestroyBuffsWithDeadTargets_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadTargets_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadTargets_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __DestroyBuffsWithDeadOwners_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadOwners_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadOwners_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DestroyBuffsWithDeadOwners_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadOwners_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.NativeFieldInfoPtr___DestroyBuffsWithDeadOwners_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.DestroyBuffsWithDeadTargetsOrOwnersSystem/<>c__DisplayClass3_0")]
    public sealed class __c__DisplayClass3_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getBuffBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_EntityOwner_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass3_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0([In] ref DeathEvent deathEvent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref deathEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, [In] ref EntityOwner owner)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref owner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_EntityOwner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass3_0()
      {
        Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, "<>c__DisplayClass3_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_getBuffBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (getBuffBuffer));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr, "<>4__this");
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr, nameof (commandBuffer));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr, 100664892);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr, 100664893);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr, 100664894);
      }

      public __c__DisplayClass3_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass3_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0>.NativeClassPtr, data));
      }

      public unsafe BufferFromEntity<BuffBuffer> getBuffBuffer
      {
        get
        {
          return *(BufferFromEntity<BuffBuffer>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_getBuffBuffer));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_getBuffBuffer), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BufferFromEntity<BuffBuffer>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe DestroyBuffsWithDeadTargetsOrOwnersSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (DestroyBuffsWithDeadTargetsOrOwnersSystem) null : new DestroyBuffsWithDeadTargetsOrOwnersSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.DestroyBuffsWithDeadTargetsOrOwnersSystem/ProjectM.<>c__DisplayClass_DestroyBuffsWithDeadTargets")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DestroyBuffsWithDeadTargets
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getBuffBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Buff_Persists_Through_Death_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BufferFromEntity<BuffBuffer> getBuffBuffer;
      [FieldOffset(40)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(56)]
      public ComponentDataFromEntity<Buff_Persists_Through_Death> _ComponentDataFromEntity_Buff_Persists_Through_Death_0;
      [FieldOffset(88)]
      public DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(120)]
      public unsafe DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376655, XrefRangeEnd = 1376675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody([In] ref DeathEvent deathEvent)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref deathEvent;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1376675, RefRangeEnd = 1376676, XrefRangeStart = 1376675, XrefRangeEnd = 1376675, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1376676, RefRangeEnd = 1376677, XrefRangeStart = 1376676, XrefRangeEnd = 1376676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376677, XrefRangeEnd = 1376679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1376684, RefRangeEnd = 1376685, XrefRangeStart = 1376679, XrefRangeEnd = 1376684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1376690, RefRangeEnd = 1376691, XrefRangeStart = 1376685, XrefRangeEnd = 1376690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DestroyBuffsWithDeadTargetsOrOwnersSystem componentSystem,
        ref DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376691, XrefRangeEnd = 1376695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376695, XrefRangeEnd = 1376701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DestroyBuffsWithDeadTargets()
      {
        Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, "<>c__DisplayClass_DestroyBuffsWithDeadTargets");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr_getBuffBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, nameof (getBuffBuffer));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, nameof (commandBuffer));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr__ComponentDataFromEntity_Buff_Persists_Through_Death_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, nameof (_ComponentDataFromEntity_Buff_Persists_Through_Death_0));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, nameof (_runtimes));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_DeathEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, 100664895);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, 100664896);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, 100664897);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, 100664898);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, 100664899);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, 100664900);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, 100664901);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, 100664902);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_deathEvent;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<DeathEvent> forParameter_deathEvent;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1376575, RefRangeEnd = 1376576, XrefRangeStart = 1376572, XrefRangeEnd = 1376575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          DestroyBuffsWithDeadTargetsOrOwnersSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1376579, RefRangeEnd = 1376580, XrefRangeStart = 1376576, XrefRangeEnd = 1376579, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_deathEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_deathEvent));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders>.NativeClassPtr, 100664903);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders>.NativeClassPtr, 100664904);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_deathEvent;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<DeathEvent>.Runtime runtime_deathEvent;

          static Runtimes()
          {
            Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_deathEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_deathEvent));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DestroyBuffsWithDeadTargetsOrOwnersSystem/ProjectM.<>c__DisplayClass_DestroyBuffsWithDeadTargets/ProjectM.RunWithoutJobSystem_000003C7$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, "RunWithoutJobSystem_000003C7$PostfixBurstDelegate");
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664905);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664906);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664907);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664908);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DestroyBuffsWithDeadTargetsOrOwnersSystem/ProjectM.<>c__DisplayClass_DestroyBuffsWithDeadTargets/ProjectM.RunWithoutJobSystem_000003C7$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376580, XrefRangeEnd = 1376594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376594, XrefRangeEnd = 1376612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376612, XrefRangeEnd = 1376627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1376654, RefRangeEnd = 1376655, XrefRangeStart = 1376627, XrefRangeEnd = 1376654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets>.NativeClassPtr, "RunWithoutJobSystem_000003C7$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664909);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664910);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664911);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664912);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664914);
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
            IL2CPP.il2cpp_field_static_get_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadTargets.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.DestroyBuffsWithDeadTargetsOrOwnersSystem/ProjectM.<>c__DisplayClass_DestroyBuffsWithDeadOwners")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DestroyBuffsWithDeadOwners
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_byref___c__DisplayClass3_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ComponentDataFromEntity<Dead> _ComponentDataFromEntity_Dead_0;
      [FieldOffset(48)]
      public DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376786, XrefRangeEnd = 1376792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref EntityOwner owner)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref owner;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 752382, RefRangeEnd = 752385, XrefRangeStart = 752382, XrefRangeEnd = 752385, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 752385, RefRangeEnd = 752388, XrefRangeStart = 752385, XrefRangeEnd = 752388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376792, XrefRangeEnd = 1376794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1376800, RefRangeEnd = 1376801, XrefRangeStart = 1376794, XrefRangeEnd = 1376800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1376806, RefRangeEnd = 1376807, XrefRangeStart = 1376801, XrefRangeEnd = 1376806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DestroyBuffsWithDeadTargetsOrOwnersSystem componentSystem,
        ref DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass3_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_byref___c__DisplayClass3_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376807, XrefRangeEnd = 1376811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376811, XrefRangeEnd = 1376817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DestroyBuffsWithDeadOwners()
      {
        Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem>.NativeClassPtr, "<>c__DisplayClass_DestroyBuffsWithDeadOwners");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, nameof (commandBuffer));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr__ComponentDataFromEntity_Dead_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, nameof (_ComponentDataFromEntity_Dead_0));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, nameof (_runtimes));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_EntityOwner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, 100664915);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, 100664916);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, 100664917);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, 100664918);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, 100664919);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_byref___c__DisplayClass3_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, 100664920);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, 100664921);
        DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, 100664922);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_owner;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<EntityOwner> forParameter_owner;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1376705, RefRangeEnd = 1376706, XrefRangeStart = 1376701, XrefRangeEnd = 1376705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          DestroyBuffsWithDeadTargetsOrOwnersSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1376710, RefRangeEnd = 1376711, XrefRangeStart = 1376706, XrefRangeEnd = 1376710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_owner));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyBuffsWithDeadTargetsOrOwnersSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders>.NativeClassPtr, 100664923);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders>.NativeClassPtr, 100664924);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_owner;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<EntityOwner>.Runtime runtime_owner;

          static Runtimes()
          {
            Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_owner));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DestroyBuffsWithDeadTargetsOrOwnersSystem/ProjectM.<>c__DisplayClass_DestroyBuffsWithDeadOwners/ProjectM.RunWithoutJobSystem_000003D0$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, "RunWithoutJobSystem_000003D0$PostfixBurstDelegate");
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664925);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664926);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664927);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664928);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DestroyBuffsWithDeadTargetsOrOwnersSystem/ProjectM.<>c__DisplayClass_DestroyBuffsWithDeadOwners/ProjectM.RunWithoutJobSystem_000003D0$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376711, XrefRangeEnd = 1376725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376725, XrefRangeEnd = 1376743, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1376743, XrefRangeEnd = 1376758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1376785, RefRangeEnd = 1376786, XrefRangeStart = 1376758, XrefRangeEnd = 1376785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners>.NativeClassPtr, "RunWithoutJobSystem_000003D0$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664929);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664930);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664931);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664932);
          DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664934);
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
            IL2CPP.il2cpp_field_static_get_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DestroyBuffsWithDeadTargetsOrOwnersSystem.__c__DisplayClass_DestroyBuffsWithDeadOwners.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
