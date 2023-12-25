// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Systems.AssetSwappingSystem
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.CastleBuilding.AssetSwapping;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Physics;
using Unity.Profiling;
using Unity.Rendering;
using Unity.Transforms;

#nullable disable
namespace ProjectM.CastleBuilding.Systems
{
  public class AssetSwappingSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___SwapCollidersAndArt_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SwapCollidersAndArt_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSwapCollidersAndArt_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203565, XrefRangeEnd = 1203586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSwappingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetSwappingSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203586, XrefRangeEnd = 1203604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssetSwappingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1203626, RefRangeEnd = 1203627, XrefRangeStart = 1203604, XrefRangeEnd = 1203626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSwapCollidersAndArt_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.NativeMethodInfoPtr___GetEntityQuery_ForSwapCollidersAndArt_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203627, XrefRangeEnd = 1203631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AssetSwappingSystem()
    {
      Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding.Systems", nameof (AssetSwappingSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr);
      AssetSwappingSystem.NativeFieldInfoPtr___SwapCollidersAndArt_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, "<>SwapCollidersAndArt_entityQuery");
      AssetSwappingSystem.NativeFieldInfoPtr___SwapCollidersAndArt_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, "<>SwapCollidersAndArt_profilerMarker");
      AssetSwappingSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, 100664585);
      AssetSwappingSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, 100664586);
      AssetSwappingSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, 100664587);
      AssetSwappingSystem.NativeMethodInfoPtr___GetEntityQuery_ForSwapCollidersAndArt_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, 100664588);
      AssetSwappingSystem.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, 100664589);
    }

    public AssetSwappingSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __SwapCollidersAndArt_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.NativeFieldInfoPtr___SwapCollidersAndArt_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.NativeFieldInfoPtr___SwapCollidersAndArt_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SwapCollidersAndArt_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.NativeFieldInfoPtr___SwapCollidersAndArt_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.NativeFieldInfoPtr___SwapCollidersAndArt_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwappingSystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AssetSwapState_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref AssetSwapState swapState)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref swapState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AssetSwapState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr);
        AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (entityManager));
        AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (commandBuffer));
        AssetSwappingSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr, 100664590);
        AssetSwappingSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_AssetSwapState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr, 100664591);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass0_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass0_0>.NativeClassPtr, data));
      }

      public unsafe EntityManager entityManager
      {
        get
        {
          return *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_entityManager));
        }
        [param: In] set
        {
          *(EntityManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_entityManager)) = value;
        }
      }

      public unsafe AssetSwappingSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (AssetSwappingSystem) null : new AssetSwappingSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssetSwappingSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwappingSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_SwapCollidersAndArt")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SwapCollidersAndArt
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_entityManager;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_LocalToWorld_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PhysicsExclude_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_DisableRendering_2;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AssetSwapState_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwappingSystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityManager entityManager;
      [FieldOffset(8)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(24)]
      public ComponentDataFromEntity<LocalToWorld> _ComponentDataFromEntity_LocalToWorld_0;
      [FieldOffset(56)]
      public ComponentDataFromEntity<PhysicsExclude> _ComponentDataFromEntity_PhysicsExclude_1;
      [FieldOffset(88)]
      public ComponentDataFromEntity<DisableRendering> _ComponentDataFromEntity_DisableRendering_2;
      [FieldOffset(120)]
      public AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(160)]
      public unsafe AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203458, XrefRangeEnd = 1203530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref AssetSwapState swapState)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref swapState;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AssetSwapState_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1203530, RefRangeEnd = 1203532, XrefRangeStart = 1203530, XrefRangeEnd = 1203530, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref AssetSwappingSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1203532, RefRangeEnd = 1203534, XrefRangeStart = 1203532, XrefRangeEnd = 1203532, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref AssetSwappingSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203534, XrefRangeEnd = 1203536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1203542, RefRangeEnd = 1203543, XrefRangeStart = 1203536, XrefRangeEnd = 1203542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1203554, RefRangeEnd = 1203555, XrefRangeStart = 1203543, XrefRangeEnd = 1203554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        AssetSwappingSystem componentSystem,
        ref AssetSwappingSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwappingSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203555, XrefRangeEnd = 1203559, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203559, XrefRangeEnd = 1203565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SwapCollidersAndArt()
      {
        Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwappingSystem>.NativeClassPtr, "<>c__DisplayClass_SwapCollidersAndArt");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr);
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr_entityManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (entityManager));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (commandBuffer));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr__ComponentDataFromEntity_LocalToWorld_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (_ComponentDataFromEntity_LocalToWorld_0));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr__ComponentDataFromEntity_PhysicsExclude_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (_ComponentDataFromEntity_PhysicsExclude_1));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr__ComponentDataFromEntity_DisableRendering_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (_ComponentDataFromEntity_DisableRendering_2));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (_runtimes));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_AssetSwapState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, 100664592);
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, 100664593);
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, 100664594);
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, 100664595);
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, 100664596);
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwappingSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, 100664597);
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, 100664598);
        AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, 100664599);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_swapState;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwappingSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<AssetSwapState> forParameter_swapState;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1203377, RefRangeEnd = 1203378, XrefRangeStart = 1203373, XrefRangeEnd = 1203377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(AssetSwappingSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwappingSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1203382, RefRangeEnd = 1203383, XrefRangeStart = 1203378, XrefRangeEnd = 1203382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_swapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_swapState));
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_AssetSwappingSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders>.NativeClassPtr, 100664600);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders>.NativeClassPtr, 100664601);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_swapState;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<AssetSwapState>.Runtime runtime_swapState;

          static Runtimes()
          {
            Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_swapState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_swapState));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwappingSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_SwapCollidersAndArt/ProjectM.CastleBuilding.Systems.RunWithoutJobSystem_00000371$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, "RunWithoutJobSystem_00000371$PostfixBurstDelegate");
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664602);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664603);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664604);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664605);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Systems.AssetSwappingSystem/ProjectM.CastleBuilding.Systems.<>c__DisplayClass_SwapCollidersAndArt/ProjectM.CastleBuilding.Systems.RunWithoutJobSystem_00000371$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203383, XrefRangeEnd = 1203397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203397, XrefRangeEnd = 1203415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1203415, XrefRangeEnd = 1203430, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1203457, RefRangeEnd = 1203458, XrefRangeStart = 1203430, XrefRangeEnd = 1203457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt>.NativeClassPtr, "RunWithoutJobSystem_00000371$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664606);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664607);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664608);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664609);
          AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664611);
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
            IL2CPP.il2cpp_field_static_get_value(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(AssetSwappingSystem.__c__DisplayClass_SwapCollidersAndArt.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
