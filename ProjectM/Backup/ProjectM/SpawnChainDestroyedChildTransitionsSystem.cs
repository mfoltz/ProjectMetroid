// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnChainDestroyedChildTransitionsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

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
  public class SpawnChainDestroyedChildTransitionsSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnChain_ListenForDestroyedChildren_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnChain_ListenForDestroyedChildren_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnChain_ListenForDestroyedChildren_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071125, XrefRangeEnd = 1071154, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnChainDestroyedChildTransitionsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071154, XrefRangeEnd = 1071190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071190, XrefRangeEnd = 1071209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnChain_ListenForDestroyedChildren_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnChain_ListenForDestroyedChildren_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1071213, RefRangeEnd = 1071214, XrefRangeStart = 1071209, XrefRangeEnd = 1071213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnChainDestroyedChildTransitionsSystem()
    {
      Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnChainDestroyedChildTransitionsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr);
      SpawnChainDestroyedChildTransitionsSystem.NativeFieldInfoPtr___SpawnChain_ListenForDestroyedChildren_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, "<>SpawnChain_ListenForDestroyedChildren_entityQuery");
      SpawnChainDestroyedChildTransitionsSystem.NativeFieldInfoPtr___SpawnChain_ListenForDestroyedChildren_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, "<>SpawnChain_ListenForDestroyedChildren_profilerMarker");
      SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, 100684384);
      SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, 100684385);
      SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, 100684386);
      SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr___GetEntityQuery_ForSpawnChain_ListenForDestroyedChildren_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, 100684387);
      SpawnChainDestroyedChildTransitionsSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, 100684388);
    }

    public SpawnChainDestroyedChildTransitionsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __SpawnChain_ListenForDestroyedChildren_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.NativeFieldInfoPtr___SpawnChain_ListenForDestroyedChildren_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.NativeFieldInfoPtr___SpawnChain_ListenForDestroyedChildren_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnChain_ListenForDestroyedChildren_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.NativeFieldInfoPtr___SpawnChain_ListenForDestroyedChildren_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.NativeFieldInfoPtr___SpawnChain_ListenForDestroyedChildren_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.SpawnChainDestroyedChildTransitionsSystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyTransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_replaceTransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_onDestroyDueToNoPlayersNearbyTransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SpawnChainChild_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref SpawnChainChild spawnChainChild)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnChainChild;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SpawnChainChild_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_destroyTransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (destroyTransitionId));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_replaceTransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (replaceTransitionId));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_onDestroyDueToNoPlayersNearbyTransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (onDestroyDueToNoPlayersNearbyTransitionId));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (commandBuffer));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, 100684389);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_SpawnChainChild_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, 100684390);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass0_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0>.NativeClassPtr, data));
      }

      public unsafe SpawnChainData.TransitionId destroyTransitionId
      {
        get
        {
          return *(SpawnChainData.TransitionId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_destroyTransitionId));
        }
        [param: In] set
        {
          *(SpawnChainData.TransitionId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_destroyTransitionId)) = value;
        }
      }

      public unsafe SpawnChainDestroyedChildTransitionsSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (SpawnChainDestroyedChildTransitionsSystem) null : new SpawnChainDestroyedChildTransitionsSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe SpawnChainData.TransitionId replaceTransitionId
      {
        get
        {
          return *(SpawnChainData.TransitionId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_replaceTransitionId));
        }
        [param: In] set
        {
          *(SpawnChainData.TransitionId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_replaceTransitionId)) = value;
        }
      }

      public unsafe SpawnChainData.TransitionId onDestroyDueToNoPlayersNearbyTransitionId
      {
        get
        {
          return *(SpawnChainData.TransitionId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_onDestroyDueToNoPlayersNearbyTransitionId));
        }
        [param: In] set
        {
          *(SpawnChainData.TransitionId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_onDestroyDueToNoPlayersNearbyTransitionId)) = value;
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnChainDestroyedChildTransitionsSystem/ProjectM.<>c__DisplayClass_SpawnChain_ListenForDestroyedChildren")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SpawnChain_ListenForDestroyedChildren
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_destroyTransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_replaceTransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_onDestroyDueToNoPlayersNearbyTransitionId;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PlacementDestroyData_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_DestroyData_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpawnChainChild_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainDestroyedChildTransitionsSystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public SpawnChainData.TransitionId destroyTransitionId;
      [FieldOffset(32)]
      public SpawnChainData.TransitionId replaceTransitionId;
      [FieldOffset(64)]
      public SpawnChainData.TransitionId onDestroyDueToNoPlayersNearbyTransitionId;
      [FieldOffset(96)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(112)]
      public ComponentDataFromEntity<PlacementDestroyData> _ComponentDataFromEntity_PlacementDestroyData_0;
      [FieldOffset(144)]
      public ComponentDataFromEntity<DestroyData> _ComponentDataFromEntity_DestroyData_1;
      [FieldOffset(176)]
      public SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(216)]
      public unsafe SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071079, XrefRangeEnd = 1071095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref SpawnChainChild spawnChainChild)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnChainChild;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpawnChainChild_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071095, RefRangeEnd = 1071096, XrefRangeStart = 1071095, XrefRangeEnd = 1071095, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071096, RefRangeEnd = 1071097, XrefRangeStart = 1071096, XrefRangeEnd = 1071096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071097, XrefRangeEnd = 1071099, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071105, RefRangeEnd = 1071106, XrefRangeStart = 1071099, XrefRangeEnd = 1071105, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1071114, RefRangeEnd = 1071115, XrefRangeStart = 1071106, XrefRangeEnd = 1071114, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        SpawnChainDestroyedChildTransitionsSystem componentSystem,
        ref SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainDestroyedChildTransitionsSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071115, XrefRangeEnd = 1071119, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071119, XrefRangeEnd = 1071125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnChain_ListenForDestroyedChildren()
      {
        Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem>.NativeClassPtr, "<>c__DisplayClass_SpawnChain_ListenForDestroyedChildren");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_destroyTransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (destroyTransitionId));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_replaceTransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (replaceTransitionId));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_onDestroyDueToNoPlayersNearbyTransitionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (onDestroyDueToNoPlayersNearbyTransitionId));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (commandBuffer));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr__ComponentDataFromEntity_PlacementDestroyData_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (_ComponentDataFromEntity_PlacementDestroyData_0));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr__ComponentDataFromEntity_DestroyData_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (_ComponentDataFromEntity_DestroyData_1));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (_runtimes));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_SpawnChainChild_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, 100684391);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, 100684392);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, 100684393);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, 100684394);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, 100684395);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainDestroyedChildTransitionsSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, 100684396);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, 100684397);
        SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, 100684398);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnChainChild;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainDestroyedChildTransitionsSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<SpawnChainChild> forParameter_spawnChainChild;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1070998, RefRangeEnd = 1070999, XrefRangeStart = 1070994, XrefRangeEnd = 1070998, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(
          SpawnChainDestroyedChildTransitionsSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainDestroyedChildTransitionsSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1071003, RefRangeEnd = 1071004, XrefRangeStart = 1070999, XrefRangeEnd = 1071003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnChainChild));
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnChainDestroyedChildTransitionsSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders>.NativeClassPtr, 100684399);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders>.NativeClassPtr, 100684400);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnChainChild;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<SpawnChainChild>.Runtime runtime_spawnChainChild;

          static Runtimes()
          {
            Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnChainChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnChainChild));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SpawnChainDestroyedChildTransitionsSystem/ProjectM.<>c__DisplayClass_SpawnChain_ListenForDestroyedChildren/ProjectM.RunWithoutJobSystem_00004A20$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, "RunWithoutJobSystem_00004A20$PostfixBurstDelegate");
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684401);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684402);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684403);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684404);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SpawnChainDestroyedChildTransitionsSystem/ProjectM.<>c__DisplayClass_SpawnChain_ListenForDestroyedChildren/ProjectM.RunWithoutJobSystem_00004A20$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071004, XrefRangeEnd = 1071018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071018, XrefRangeEnd = 1071036, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1071036, XrefRangeEnd = 1071051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1071078, RefRangeEnd = 1071079, XrefRangeStart = 1071051, XrefRangeEnd = 1071078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren>.NativeClassPtr, "RunWithoutJobSystem_00004A20$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684405);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684406);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684407);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684408);
          SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684410);
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
            IL2CPP.il2cpp_field_static_get_value(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SpawnChainDestroyedChildTransitionsSystem.__c__DisplayClass_SpawnChain_ListenForDestroyedChildren.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
