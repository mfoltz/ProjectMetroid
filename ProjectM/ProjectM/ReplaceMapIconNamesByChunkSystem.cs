// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceMapIconNamesByChunkSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class ReplaceMapIconNamesByChunkSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ChunkDataRemappingManager;
    private static readonly System.IntPtr NativeFieldInfoPtr___ReplaceMapIconNamesByChunk_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___ReplaceMapIconNamesByChunk_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForReplaceMapIconNamesByChunk_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022057, XrefRangeEnd = 1022063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022063, XrefRangeEnd = 1022078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReplaceMapIconNamesByChunkSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022078, XrefRangeEnd = 1022096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1022118, RefRangeEnd = 1022119, XrefRangeStart = 1022096, XrefRangeEnd = 1022118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForReplaceMapIconNamesByChunk_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr___GetEntityQuery_ForReplaceMapIconNamesByChunk_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1022123, RefRangeEnd = 1022124, XrefRangeStart = 1022119, XrefRangeEnd = 1022123, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReplaceMapIconNamesByChunkSystem()
    {
      Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ReplaceMapIconNamesByChunkSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr);
      ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr__ChunkDataRemappingManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, nameof (_ChunkDataRemappingManager));
      ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr___ReplaceMapIconNamesByChunk_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, "<>ReplaceMapIconNamesByChunk_entityQuery");
      ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr___ReplaceMapIconNamesByChunk_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, "<>ReplaceMapIconNamesByChunk_profilerMarker");
      ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, 100679795);
      ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, 100679796);
      ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, 100679797);
      ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, 100679798);
      ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr___GetEntityQuery_ForReplaceMapIconNamesByChunk_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, 100679799);
      ReplaceMapIconNamesByChunkSystem.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, 100679800);
    }

    public ReplaceMapIconNamesByChunkSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ChunkDataRemappingManager _ChunkDataRemappingManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr__ChunkDataRemappingManager));
        return pointer == System.IntPtr.Zero ? (ChunkDataRemappingManager) null : new ChunkDataRemappingManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr__ChunkDataRemappingManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __ReplaceMapIconNamesByChunk_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr___ReplaceMapIconNamesByChunk_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr___ReplaceMapIconNamesByChunk_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __ReplaceMapIconNamesByChunk_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr___ReplaceMapIconNamesByChunk_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReplaceMapIconNamesByChunkSystem.NativeFieldInfoPtr___ReplaceMapIconNamesByChunk_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ReplaceMapIconNamesByChunkSystem/<>c__DisplayClass2_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass2_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapIconByChunkLookup;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_MapIconData_byref_Translation_0;
      [FieldOffset(0)]
      public ChunkRemappingLookup<LocalizationKey> mapIconByChunkLookup;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref MapIconData mapIconData,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapIconData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_MapIconData_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0.NativeFieldInfoPtr_mapIconByChunkLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr, nameof (mapIconByChunkLookup));
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr, 100679801);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_MapIconData_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr, 100679802);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ReplaceMapIconNamesByChunkSystem/ProjectM.<>c__DisplayClass_ReplaceMapIconNamesByChunk")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ReplaceMapIconNamesByChunk
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_mapIconByChunkLookup;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapIconData_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceMapIconNamesByChunkSystem_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ChunkRemappingLookup<LocalizationKey> mapIconByChunkLookup;
      [FieldOffset(16)]
      public ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(88)]
      public unsafe ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022028, XrefRangeEnd = 1022032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref MapIconData mapIconData,
        [In] ref Translation translation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref mapIconData;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref translation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapIconData_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(103)]
      [CachedScanResults(RefRangeStart = 239315, RefRangeEnd = 239418, XrefRangeStart = 239315, XrefRangeEnd = 239418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(92)]
      [CachedScanResults(RefRangeStart = 195460, RefRangeEnd = 195552, XrefRangeStart = 195460, XrefRangeEnd = 195552, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022032, XrefRangeEnd = 1022034, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1022043, RefRangeEnd = 1022044, XrefRangeStart = 1022034, XrefRangeEnd = 1022043, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1022046, RefRangeEnd = 1022047, XrefRangeStart = 1022044, XrefRangeEnd = 1022046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ReplaceMapIconNamesByChunkSystem componentSystem,
        ref ReplaceMapIconNamesByChunkSystem.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceMapIconNamesByChunkSystem_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022047, XrefRangeEnd = 1022051, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022051, XrefRangeEnd = 1022057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ReplaceMapIconNamesByChunk()
      {
        Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem>.NativeClassPtr, "<>c__DisplayClass_ReplaceMapIconNamesByChunk");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr_mapIconByChunkLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, nameof (mapIconByChunkLookup));
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, nameof (_runtimes));
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_MapIconData_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, 100679803);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, 100679804);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, 100679805);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, 100679806);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, 100679807);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceMapIconNamesByChunkSystem_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, 100679808);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, 100679809);
        ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, 100679810);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_mapIconData;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_translation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceMapIconNamesByChunkSystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<MapIconData> forParameter_mapIconData;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_translation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1021944, RefRangeEnd = 1021945, XrefRangeStart = 1021937, XrefRangeEnd = 1021944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ReplaceMapIconNamesByChunkSystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceMapIconNamesByChunkSystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1021952, RefRangeEnd = 1021953, XrefRangeStart = 1021945, XrefRangeEnd = 1021952, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_mapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_mapIconData));
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_translation));
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ReplaceMapIconNamesByChunkSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders>.NativeClassPtr, 100679811);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders>.NativeClassPtr, 100679812);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_mapIconData;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_translation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<MapIconData>.Runtime runtime_mapIconData;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_translation;

          static Runtimes()
          {
            Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_mapIconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_mapIconData));
            ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_translation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_translation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.ReplaceMapIconNamesByChunkSystem/ProjectM.<>c__DisplayClass_ReplaceMapIconNamesByChunk/ProjectM.RunWithoutJobSystem_00003CCC$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, "RunWithoutJobSystem_00003CCC$PostfixBurstDelegate");
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679813);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679814);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679815);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679816);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.ReplaceMapIconNamesByChunkSystem/ProjectM.<>c__DisplayClass_ReplaceMapIconNamesByChunk/ProjectM.RunWithoutJobSystem_00003CCC$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021953, XrefRangeEnd = 1021967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021967, XrefRangeEnd = 1021985, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021985, XrefRangeEnd = 1022000, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1022027, RefRangeEnd = 1022028, XrefRangeStart = 1022000, XrefRangeEnd = 1022027, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk>.NativeClassPtr, "RunWithoutJobSystem_00003CCC$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679817);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679818);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679819);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679820);
          ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679822);
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
            IL2CPP.il2cpp_field_static_get_value(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(ReplaceMapIconNamesByChunkSystem.__c__DisplayClass_ReplaceMapIconNamesByChunk.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
