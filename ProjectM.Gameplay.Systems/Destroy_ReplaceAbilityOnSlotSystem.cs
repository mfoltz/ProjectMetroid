// Decompiled with JetBrains decompiler
// Type: ProjectM.Destroy_ReplaceAbilityOnSlotSystem
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
  public class Destroy_ReplaceAbilityOnSlotSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___Destroy_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___Destroy_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381155, XrefRangeEnd = 1381173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Destroy_ReplaceAbilityOnSlotSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381173, XrefRangeEnd = 1381209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381209, XrefRangeEnd = 1381228, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDestroy_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1381232, RefRangeEnd = 1381233, XrefRangeStart = 1381228, XrefRangeEnd = 1381232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Destroy_ReplaceAbilityOnSlotSystem()
    {
      Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM", nameof (Destroy_ReplaceAbilityOnSlotSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr);
      Destroy_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Destroy_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Destroy_entityQuery");
      Destroy_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Destroy_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>Destroy_profilerMarker");
      Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665451);
      Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665452);
      Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665453);
      Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr___GetEntityQuery_ForDestroy_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665454);
      Destroy_ReplaceAbilityOnSlotSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, 100665455);
    }

    public Destroy_ReplaceAbilityOnSlotSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __Destroy_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Destroy_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Destroy_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __Destroy_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Destroy_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Destroy_ReplaceAbilityOnSlotSystem.NativeFieldInfoPtr___Destroy_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Destroy_ReplaceAbilityOnSlotSystem/<>c__DisplayClass0_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass0_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ReplaceAbilityOnSlotData_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(Entity entity, [In] ref ReplaceAbilityOnSlotData replaceData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref replaceData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ReplaceAbilityOnSlotData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0>.NativeClassPtr);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0>.NativeClassPtr, nameof (commandBuffer));
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0>.NativeClassPtr, 100665456);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_ReplaceAbilityOnSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0>.NativeClassPtr, 100665457);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Destroy_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Destroy")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_Destroy
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_commandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ReplaceAbilityOnSlotData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass0_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public EntityCommandBuffer commandBuffer;
      [FieldOffset(16)]
      public Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(56)]
      public unsafe Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381130, XrefRangeEnd = 1381133, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, [In] ref ReplaceAbilityOnSlotData replaceData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref replaceData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ReplaceAbilityOnSlotData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381133, XrefRangeEnd = 1381135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381141, RefRangeEnd = 1381142, XrefRangeStart = 1381135, XrefRangeEnd = 1381141, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1381144, RefRangeEnd = 1381145, XrefRangeStart = 1381142, XrefRangeEnd = 1381144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        Destroy_ReplaceAbilityOnSlotSystem componentSystem,
        ref Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass0_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass0_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381145, XrefRangeEnd = 1381149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381149, XrefRangeEnd = 1381155, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_Destroy()
      {
        Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem>.NativeClassPtr, "<>c__DisplayClass_Destroy");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_commandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (commandBuffer));
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (_runtimes));
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_ReplaceAbilityOnSlotData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665458);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665459);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665460);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665461);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665462);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_ReplaceAbilityOnSlotSystem_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665463);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665464);
        Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, 100665465);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_replaceData;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_ReplaceAbilityOnSlotSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<ReplaceAbilityOnSlotData> forParameter_replaceData;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381049, RefRangeEnd = 1381050, XrefRangeStart = 1381045, XrefRangeEnd = 1381049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(Destroy_ReplaceAbilityOnSlotSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_ReplaceAbilityOnSlotSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381054, RefRangeEnd = 1381055, XrefRangeStart = 1381050, XrefRangeEnd = 1381054, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_replaceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_replaceData));
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_Destroy_ReplaceAbilityOnSlotSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, 100665466);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, 100665467);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_replaceData;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<ReplaceAbilityOnSlotData>.Runtime runtime_replaceData;

          static Runtimes()
          {
            Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_replaceData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_replaceData));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.Destroy_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Destroy/ProjectM.RunWithoutJobSystem_000004FF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, "RunWithoutJobSystem_000004FF$PostfixBurstDelegate");
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665468);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665469);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665470);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100665471);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.Destroy_ReplaceAbilityOnSlotSystem/ProjectM.<>c__DisplayClass_Destroy/ProjectM.RunWithoutJobSystem_000004FF$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381055, XrefRangeEnd = 1381069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381069, XrefRangeEnd = 1381087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1381087, XrefRangeEnd = 1381102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1381129, RefRangeEnd = 1381130, XrefRangeStart = 1381102, XrefRangeEnd = 1381129, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy>.NativeClassPtr, "RunWithoutJobSystem_000004FF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665472);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665473);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665474);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665475);
          Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100665477);
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
            IL2CPP.il2cpp_field_static_get_value(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(Destroy_ReplaceAbilityOnSlotSystem.__c__DisplayClass_Destroy.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
