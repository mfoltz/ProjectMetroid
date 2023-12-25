// Decompiled with JetBrains decompiler
// Type: ProjectM.RandomizedSpawnChainDestroySystem
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
  public class RandomizedSpawnChainDestroySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizedSpawnChain_DestroyChildsOnDestroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___RandomizedSpawnChain_DestroyChildsOnDestroy_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChain_DestroyChildsOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070377, XrefRangeEnd = 1070396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe RandomizedSpawnChainDestroySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070396, XrefRangeEnd = 1070432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070432, XrefRangeEnd = 1070451, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForRandomizedSpawnChain_DestroyChildsOnDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChain_DestroyChildsOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1070455, RefRangeEnd = 1070456, XrefRangeStart = 1070451, XrefRangeEnd = 1070455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RandomizedSpawnChainDestroySystem()
    {
      Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RandomizedSpawnChainDestroySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr);
      RandomizedSpawnChainDestroySystem.NativeFieldInfoPtr___RandomizedSpawnChain_DestroyChildsOnDestroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, "<>RandomizedSpawnChain_DestroyChildsOnDestroy_entityQuery");
      RandomizedSpawnChainDestroySystem.NativeFieldInfoPtr___RandomizedSpawnChain_DestroyChildsOnDestroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, "<>RandomizedSpawnChain_DestroyChildsOnDestroy_profilerMarker");
      RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, 100684286);
      RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, 100684287);
      RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, 100684288);
      RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr___GetEntityQuery_ForRandomizedSpawnChain_DestroyChildsOnDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, 100684289);
      RandomizedSpawnChainDestroySystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, 100684290);
    }

    public RandomizedSpawnChainDestroySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __RandomizedSpawnChain_DestroyChildsOnDestroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainDestroySystem.NativeFieldInfoPtr___RandomizedSpawnChain_DestroyChildsOnDestroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainDestroySystem.NativeFieldInfoPtr___RandomizedSpawnChain_DestroyChildsOnDestroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __RandomizedSpawnChain_DestroyChildsOnDestroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainDestroySystem.NativeFieldInfoPtr___RandomizedSpawnChain_DestroyChildsOnDestroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainDestroySystem.NativeFieldInfoPtr___RandomizedSpawnChain_DestroyChildsOnDestroy_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.RandomizedSpawnChainDestroySystem/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RandomizedSpawnChain_0;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(ref RandomizedSpawnChain activeElement)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeElement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RandomizedSpawnChain_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (commandBuffer));
        RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, 100684291);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_byref_RandomizedSpawnChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, 100684292);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public __c__DisplayClass0_0()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0>.NativeClassPtr, data));
      }

      public unsafe RandomizedSpawnChainDestroySystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (RandomizedSpawnChainDestroySystem) null : new RandomizedSpawnChainDestroySystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe EntityCommandBuffer commandBuffer
      {
        get
        {
          return *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer));
        }
        [param: In] set
        {
          *(EntityCommandBuffer*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.RandomizedSpawnChainDestroySystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_DestroyTag_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RandomizedSpawnChain_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainDestroySystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public ComponentDataFromEntity<PrefabGUID> _ComponentDataFromEntity_PrefabGUID_0;
      [FieldOffset(48)]
      public ComponentDataFromEntity<DestroyTag> _ComponentDataFromEntity_DestroyTag_1;
      [FieldOffset(80)]
      public RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(112)]
      public unsafe RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070340, XrefRangeEnd = 1070350, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(ref RandomizedSpawnChain activeElement)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref activeElement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RandomizedSpawnChain_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723251, RefRangeEnd = 723285, XrefRangeStart = 723251, XrefRangeEnd = 723285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(34)]
      [CachedScanResults(RefRangeStart = 723285, RefRangeEnd = 723319, XrefRangeStart = 723285, XrefRangeEnd = 723319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070350, XrefRangeEnd = 1070352, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1070357, RefRangeEnd = 1070358, XrefRangeStart = 1070352, XrefRangeEnd = 1070357, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1070366, RefRangeEnd = 1070367, XrefRangeStart = 1070358, XrefRangeEnd = 1070366, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        RandomizedSpawnChainDestroySystem componentSystem,
        ref RandomizedSpawnChainDestroySystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) displayClass);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainDestroySystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070367, XrefRangeEnd = 1070371, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070371, XrefRangeEnd = 1070377, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy()
      {
        Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem>.NativeClassPtr, "<>c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (commandBuffer));
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__ComponentDataFromEntity_PrefabGUID_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (_ComponentDataFromEntity_PrefabGUID_0));
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__ComponentDataFromEntity_DestroyTag_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (_ComponentDataFromEntity_DestroyTag_1));
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (_runtimes));
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_byref_RandomizedSpawnChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684293);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684294);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684295);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684296);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684297);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainDestroySystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684298);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684299);
        RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, 100684300);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_activeElement;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainDestroySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_IComponentData<RandomizedSpawnChain> forParameter_activeElement;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1070260, RefRangeEnd = 1070261, XrefRangeStart = 1070257, XrefRangeEnd = 1070260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(RandomizedSpawnChainDestroySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainDestroySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1070264, RefRangeEnd = 1070265, XrefRangeStart = 1070261, XrefRangeEnd = 1070264, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_activeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_activeElement));
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_RandomizedSpawnChainDestroySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100684301);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, 100684302);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_activeElement;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_IComponentData<RandomizedSpawnChain>.Runtime runtime_activeElement;

          static Runtimes()
          {
            Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_activeElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_activeElement));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.RandomizedSpawnChainDestroySystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy/ProjectM.RunWithoutJobSystem_000049E2$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, "RunWithoutJobSystem_000049E2$PostfixBurstDelegate");
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684303);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684304);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684305);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100684306);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.RandomizedSpawnChainDestroySystem/ProjectM.<>c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy/ProjectM.RunWithoutJobSystem_000049E2$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070265, XrefRangeEnd = 1070279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070279, XrefRangeEnd = 1070297, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1070297, XrefRangeEnd = 1070312, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1070339, RefRangeEnd = 1070340, XrefRangeStart = 1070312, XrefRangeEnd = 1070339, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy>.NativeClassPtr, "RunWithoutJobSystem_000049E2$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684307);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684308);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684309);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684310);
          RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100684312);
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
            IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(RandomizedSpawnChainDestroySystem.__c__DisplayClass_RandomizedSpawnChain_DestroyChildsOnDestroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
