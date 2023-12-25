// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.InteractSystemClient_Sequences
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  public class InteractSystemClient_Sequences : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DestroyBarrierSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GetActiveInteractableQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupActiveInteractableSequences_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SetupActiveInteractableSequences_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveActiveInteractableSequences_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RemoveActiveInteractableSequences_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___TagActiveInteractables_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___TagActiveInteractables_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TagActiveInteractables_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSetupActiveInteractableSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRemoveActiveInteractableSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForTagActiveInteractables_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449820, XrefRangeEnd = 1449850, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractSystemClient_Sequences.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449850, XrefRangeEnd = 1449904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractSystemClient_Sequences.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1449937, RefRangeEnd = 1449938, XrefRangeStart = 1449904, XrefRangeEnd = 1449937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TagActiveInteractables()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.NativeMethodInfoPtr_TagActiveInteractables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InteractSystemClient_Sequences()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449938, XrefRangeEnd = 1450015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractSystemClient_Sequences.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450015, XrefRangeEnd = 1450034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSetupActiveInteractableSequences_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.NativeMethodInfoPtr___GetEntityQuery_ForSetupActiveInteractableSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450034, XrefRangeEnd = 1450053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRemoveActiveInteractableSequences_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.NativeMethodInfoPtr___GetEntityQuery_ForRemoveActiveInteractableSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1450053, XrefRangeEnd = 1450069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForTagActiveInteractables_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.NativeMethodInfoPtr___GetEntityQuery_ForTagActiveInteractables_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1450073, RefRangeEnd = 1450074, XrefRangeStart = 1450069, XrefRangeEnd = 1450073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InteractSystemClient_Sequences()
    {
      Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (InteractSystemClient_Sequences));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr);
      InteractSystemClient_Sequences.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      InteractSystemClient_Sequences.NativeFieldInfoPtr__DestroyBarrierSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, nameof (_DestroyBarrierSystem));
      InteractSystemClient_Sequences.NativeFieldInfoPtr__GetActiveInteractableQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, nameof (_GetActiveInteractableQuery));
      InteractSystemClient_Sequences.NativeFieldInfoPtr___SetupActiveInteractableSequences_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>SetupActiveInteractableSequences_entityQuery");
      InteractSystemClient_Sequences.NativeFieldInfoPtr___SetupActiveInteractableSequences_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>SetupActiveInteractableSequences_profilerMarker");
      InteractSystemClient_Sequences.NativeFieldInfoPtr___RemoveActiveInteractableSequences_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>RemoveActiveInteractableSequences_entityQuery");
      InteractSystemClient_Sequences.NativeFieldInfoPtr___RemoveActiveInteractableSequences_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>RemoveActiveInteractableSequences_profilerMarker");
      InteractSystemClient_Sequences.NativeFieldInfoPtr___TagActiveInteractables_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>TagActiveInteractables_entityQuery");
      InteractSystemClient_Sequences.NativeFieldInfoPtr___TagActiveInteractables_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>TagActiveInteractables_profilerMarker");
      InteractSystemClient_Sequences.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672583);
      InteractSystemClient_Sequences.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672584);
      InteractSystemClient_Sequences.NativeMethodInfoPtr_TagActiveInteractables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672585);
      InteractSystemClient_Sequences.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672586);
      InteractSystemClient_Sequences.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672587);
      InteractSystemClient_Sequences.NativeMethodInfoPtr___GetEntityQuery_ForSetupActiveInteractableSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672588);
      InteractSystemClient_Sequences.NativeMethodInfoPtr___GetEntityQuery_ForRemoveActiveInteractableSequences_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672589);
      InteractSystemClient_Sequences.NativeMethodInfoPtr___GetEntityQuery_ForTagActiveInteractables_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672590);
      InteractSystemClient_Sequences.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, 100672591);
    }

    public InteractSystemClient_Sequences(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe PostUpdateBarrier _DestroyBarrierSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr__DestroyBarrierSystem));
        return pointer == System.IntPtr.Zero ? (PostUpdateBarrier) null : new PostUpdateBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr__DestroyBarrierSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _GetActiveInteractableQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr__GetActiveInteractableQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr__GetActiveInteractableQuery)) = value;
      }
    }

    public unsafe EntityQuery __SetupActiveInteractableSequences_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___SetupActiveInteractableSequences_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___SetupActiveInteractableSequences_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SetupActiveInteractableSequences_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___SetupActiveInteractableSequences_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___SetupActiveInteractableSequences_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __RemoveActiveInteractableSequences_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___RemoveActiveInteractableSequences_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___RemoveActiveInteractableSequences_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RemoveActiveInteractableSequences_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___RemoveActiveInteractableSequences_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___RemoveActiveInteractableSequences_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __TagActiveInteractables_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___TagActiveInteractables_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___TagActiveInteractables_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __TagActiveInteractables_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___TagActiveInteractables_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.NativeFieldInfoPtr___TagActiveInteractables_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractSystemClient_Sequences/<>c__DisplayClass4_0")]
    public sealed class __c__DisplayClass4_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractableSequence_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_InteractableSequence_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, ref InteractableSequence interactable)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactable;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractableSequence_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(Entity entity, ref InteractableSequence interactable)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactable;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_InteractableSequence_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr);
        InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr, nameof (prefabMap));
        InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
        InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr_destroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr, nameof (destroyCommandBuffer));
        InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr, 100672592);
        InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_InteractableSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr, 100672593);
        InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_InteractableSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr, 100672594);
      }

      public __c__DisplayClass4_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass4_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass4_0>.NativeClassPtr, data));
      }

      public unsafe PrefabLookupMap prefabMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr_prefabMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr_prefabMap)) = value;
        }
      }

      public unsafe InteractSystemClient_Sequences __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractSystemClient_Sequences) null : new InteractSystemClient_Sequences(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer destroyCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr_destroyCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass4_0.NativeFieldInfoPtr_destroyCommandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractSystemClient_Sequences/<>c__DisplayClass5_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass5_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getInteractable;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeInteractables;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TagActiveInteractables_b__0_Internal_Void_Entity_byref_SpellTarget_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Interactable> getInteractable;
      [FieldOffset(32)]
      public NativeList<Entity> activeInteractables;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _TagActiveInteractables_b__0(Entity entity, [In] ref SpellTarget interactTarget)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactTarget;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass5_0.NativeMethodInfoPtr__TagActiveInteractables_b__0_Internal_Void_Entity_byref_SpellTarget_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass5_0>.NativeClassPtr);
        InteractSystemClient_Sequences.__c__DisplayClass5_0.NativeFieldInfoPtr_getInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass5_0>.NativeClassPtr, nameof (getInteractable));
        InteractSystemClient_Sequences.__c__DisplayClass5_0.NativeFieldInfoPtr_activeInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass5_0>.NativeClassPtr, nameof (activeInteractables));
        InteractSystemClient_Sequences.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass5_0>.NativeClassPtr, 100672595);
        InteractSystemClient_Sequences.__c__DisplayClass5_0.NativeMethodInfoPtr__TagActiveInteractables_b__0_Internal_Void_Entity_byref_SpellTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass5_0>.NativeClassPtr, 100672596);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass5_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractSystemClient_Sequences/ProjectM.Gameplay.Systems.<>c__DisplayClass_SetupActiveInteractableSequences")]
    public sealed class __c__DisplayClass_SetupActiveInteractableSequences : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractableSequence_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass4_0_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449618, XrefRangeEnd = 1449623, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref InteractableSequence interactable)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactable;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractableSequence_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InteractSystemClient_Sequences.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 998670, RefRangeEnd = 998679, XrefRangeStart = 998670, XrefRangeEnd = 998679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InteractSystemClient_Sequences.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449623, XrefRangeEnd = 1449641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1449647, RefRangeEnd = 1449648, XrefRangeStart = 1449641, XrefRangeEnd = 1449647, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(9)]
      [CachedScanResults(RefRangeStart = 998707, RefRangeEnd = 998716, XrefRangeStart = 998707, XrefRangeEnd = 998716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InteractSystemClient_Sequences componentSystem,
        ref InteractSystemClient_Sequences.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SetupActiveInteractableSequences()
      {
        Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>c__DisplayClass_SetupActiveInteractableSequences");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr);
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, nameof (prefabMap));
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, "<>4__this");
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, nameof (_runtimes));
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, nameof (_performLambdaDelegate));
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractableSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, 100672597);
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, 100672598);
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, 100672599);
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, 100672601);
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, 100672602);
        InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, 100672603);
      }

      public __c__DisplayClass_SetupActiveInteractableSequences(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_SetupActiveInteractableSequences()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, data));
      }

      public unsafe PrefabLookupMap prefabMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr_prefabMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr_prefabMap)) = value;
        }
      }

      public unsafe InteractSystemClient_Sequences __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractSystemClient_Sequences) null : new InteractSystemClient_Sequences(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interactable;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<InteractableSequence> forParameter_interactable;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449608, XrefRangeEnd = 1449612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(InteractSystemClient_Sequences componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1449617, RefRangeEnd = 1449618, XrefRangeStart = 1449612, XrefRangeEnd = 1449617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interactable));
          InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, 100672604);
          InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, 100672605);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interactable;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<InteractableSequence>.StructuralChangeRuntime runtime_interactable;

          static Runtimes()
          {
            Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interactable));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_SetupActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractSystemClient_Sequences/ProjectM.Gameplay.Systems.<>c__DisplayClass_RemoveActiveInteractableSequences")]
    public sealed class __c__DisplayClass_RemoveActiveInteractableSequences : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabMap;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr__performLambdaDelegate;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractableSequence_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass4_0_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1449677, RefRangeEnd = 1449678, XrefRangeStart = 1449658, XrefRangeEnd = 1449677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref InteractableSequence interactable)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactable;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractableSequence_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449678, XrefRangeEnd = 1449679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InteractSystemClient_Sequences.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1449680, RefRangeEnd = 1449681, XrefRangeStart = 1449679, XrefRangeEnd = 1449680, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InteractSystemClient_Sequences.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449681, XrefRangeEnd = 1449695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void PerformLambda(void* jobStructPtr, void* runtimesPtr, Entity entity)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) jobStructPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) runtimesPtr;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1449701, RefRangeEnd = 1449702, XrefRangeStart = 1449695, XrefRangeEnd = 1449701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void Execute(ComponentSystemBase componentSystem, EntityQuery query)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &query;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1449703, RefRangeEnd = 1449704, XrefRangeStart = 1449702, XrefRangeEnd = 1449703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InteractSystemClient_Sequences componentSystem,
        ref InteractSystemClient_Sequences.__c__DisplayClass4_0 displayClass)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass4_0_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RemoveActiveInteractableSequences()
      {
        Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>c__DisplayClass_RemoveActiveInteractableSequences");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr);
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, "<>4__this");
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr_destroyCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, nameof (destroyCommandBuffer));
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr_prefabMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, nameof (prefabMap));
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, nameof (_runtimes));
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__performLambdaDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, nameof (_performLambdaDelegate));
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_InteractableSequence_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, 100672606);
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, 100672607);
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, 100672608);
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_PerformLambda_Public_Static_Void_ptr_Void_ptr_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, 100672610);
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_Execute_Public_Void_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, 100672611);
        InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, 100672612);
      }

      public __c__DisplayClass_RemoveActiveInteractableSequences(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass_RemoveActiveInteractableSequences()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, data));
      }

      public unsafe InteractSystemClient_Sequences __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (InteractSystemClient_Sequences) null : new InteractSystemClient_Sequences(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer destroyCommandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr_destroyCommandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr_destroyCommandBuffer)) = value;
        }
      }

      public unsafe PrefabLookupMap prefabMap
      {
        get
        {
          return *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr_prefabMap));
        }
        [param: In] set
        {
          *(PrefabLookupMap*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr_prefabMap)) = value;
        }
      }

      public unsafe InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders _lambdaParameterValueProviders
      {
        get
        {
          return *(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__lambdaParameterValueProviders));
        }
        [param: In] set
        {
          *(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__lambdaParameterValueProviders)) = value;
        }
      }

      public unsafe InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes* _runtimes
      {
        get
        {
          return (InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes*) (void*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__runtimes));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__runtimes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) (System.IntPtr) value));
        }
      }

      public static unsafe StructuralChangeEntityProvider.PerformLambdaDelegate _performLambdaDelegate
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__performLambdaDelegate, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (StructuralChangeEntityProvider.PerformLambdaDelegate) null : new StructuralChangeEntityProvider.PerformLambdaDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.NativeFieldInfoPtr__performLambdaDelegate, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interactable;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<InteractableSequence> forParameter_interactable;

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449648, XrefRangeEnd = 1449652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(InteractSystemClient_Sequences componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1449657, RefRangeEnd = 1449658, XrefRangeStart = 1449652, XrefRangeEnd = 1449657, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes PrepareToExecuteWithStructuralChanges(
          ComponentSystemBase p0,
          EntityQuery p1)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p0);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interactable));
          InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, 100672613);
          InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteWithStructuralChanges_Public_Runtimes_ComponentSystemBase_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, 100672614);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr__entityProvider;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interactable;
          [FieldOffset(0)]
          public StructuralChangeEntityProvider _entityProvider;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_Entity.StructuralChangeRuntime runtime_entity;
          [FieldOffset(72)]
          public LambdaParameterValueProvider_IComponentData<InteractableSequence>.StructuralChangeRuntime runtime_interactable;

          static Runtimes()
          {
            Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr__entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (_entityProvider));
            InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interactable));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_RemoveActiveInteractableSequences.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.Gameplay.Systems.InteractSystemClient_Sequences/ProjectM.Gameplay.Systems.<>c__DisplayClass_TagActiveInteractables")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_TagActiveInteractables
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getInteractable;
      private static readonly System.IntPtr NativeFieldInfoPtr_activeInteractables;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass5_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Interactable> getInteractable;
      [FieldOffset(32)]
      public NativeList<Entity> activeInteractables;
      [FieldOffset(48)]
      public InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449789, XrefRangeEnd = 1449798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref SpellTarget interactTarget)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref interactTarget;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 507623, RefRangeEnd = 507633, XrefRangeStart = 507623, XrefRangeEnd = 507633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref InteractSystemClient_Sequences.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(10)]
      [CachedScanResults(RefRangeStart = 1049298, RefRangeEnd = 1049308, XrefRangeStart = 1049298, XrefRangeEnd = 1049308, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref InteractSystemClient_Sequences.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449798, XrefRangeEnd = 1449800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1449806, RefRangeEnd = 1449807, XrefRangeStart = 1449800, XrefRangeEnd = 1449806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1449809, RefRangeEnd = 1449810, XrefRangeStart = 1449807, XrefRangeEnd = 1449809, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        InteractSystemClient_Sequences componentSystem,
        ref InteractSystemClient_Sequences.__c__DisplayClass5_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass5_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449810, XrefRangeEnd = 1449814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449814, XrefRangeEnd = 1449820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_TagActiveInteractables()
      {
        Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences>.NativeClassPtr, "<>c__DisplayClass_TagActiveInteractables");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr);
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr_getInteractable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, nameof (getInteractable));
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr_activeInteractables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, nameof (activeInteractables));
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, nameof (_runtimes));
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpellTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, 100672615);
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, 100672616);
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, 100672617);
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, 100672618);
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, 100672619);
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_byref___c__DisplayClass5_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, 100672620);
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, 100672621);
        InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, 100672622);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_interactTarget;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SpellTarget> forParameter_interactTarget;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1449708, RefRangeEnd = 1449709, XrefRangeStart = 1449704, XrefRangeEnd = 1449708, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(InteractSystemClient_Sequences componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1449713, RefRangeEnd = 1449714, XrefRangeStart = 1449709, XrefRangeEnd = 1449713, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_interactTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_interactTarget));
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_InteractSystemClient_Sequences_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders>.NativeClassPtr, 100672623);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders>.NativeClassPtr, 100672624);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_interactTarget;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SpellTarget>.Runtime runtime_interactTarget;

          static Runtimes()
          {
            Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_interactTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_interactTarget));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.InteractSystemClient_Sequences/ProjectM.Gameplay.Systems.<>c__DisplayClass_TagActiveInteractables/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001659$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, "RunWithoutJobSystem_00001659$PostfixBurstDelegate");
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672625);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672626);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672627);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100672628);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Gameplay.Systems.InteractSystemClient_Sequences/ProjectM.Gameplay.Systems.<>c__DisplayClass_TagActiveInteractables/ProjectM.Gameplay.Systems.RunWithoutJobSystem_00001659$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449714, XrefRangeEnd = 1449728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449728, XrefRangeEnd = 1449746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449746, XrefRangeEnd = 1449761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1449788, RefRangeEnd = 1449789, XrefRangeStart = 1449761, XrefRangeEnd = 1449788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables>.NativeClassPtr, "RunWithoutJobSystem_00001659$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672629);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672630);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672631);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672632);
          InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100672634);
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
            IL2CPP.il2cpp_field_static_get_value(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(InteractSystemClient_Sequences.__c__DisplayClass_TagActiveInteractables.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
