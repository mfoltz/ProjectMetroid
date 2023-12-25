// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnSleepingBuffSystem_Client
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
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class SpawnSleepingBuffSystem_Client : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnSleepingBuff_Update_Client_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___SpawnSleepingBuff_Update_Client_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_Buff_byref_SpawnSleepingBuff_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForSpawnSleepingBuff_Update_Client_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001989, XrefRangeEnd = 1002002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnSleepingBuffSystem_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__0_0(
      Entity entity,
      [In] ref Buff buff,
      [In] ref SpawnSleepingBuff spawnSleepingBuff)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnSleepingBuff;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_Buff_byref_SpawnSleepingBuff_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002002, XrefRangeEnd = 1002038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002038, XrefRangeEnd = 1002057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForSpawnSleepingBuff_Update_Client_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForSpawnSleepingBuff_Update_Client_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1002061, RefRangeEnd = 1002062, XrefRangeStart = 1002057, XrefRangeEnd = 1002061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnSleepingBuffSystem_Client()
    {
      Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnSleepingBuffSystem_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr);
      SpawnSleepingBuffSystem_Client.NativeFieldInfoPtr___SpawnSleepingBuff_Update_Client_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, "<>SpawnSleepingBuff_Update_Client_entityQuery");
      SpawnSleepingBuffSystem_Client.NativeFieldInfoPtr___SpawnSleepingBuff_Update_Client_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, "<>SpawnSleepingBuff_Update_Client_profilerMarker");
      SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, 100677578);
      SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, 100677579);
      SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_Buff_byref_SpawnSleepingBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, 100677580);
      SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, 100677581);
      SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForSpawnSleepingBuff_Update_Client_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, 100677582);
      SpawnSleepingBuffSystem_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, 100677583);
    }

    public SpawnSleepingBuffSystem_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __SpawnSleepingBuff_Update_Client_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnSleepingBuffSystem_Client.NativeFieldInfoPtr___SpawnSleepingBuff_Update_Client_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnSleepingBuffSystem_Client.NativeFieldInfoPtr___SpawnSleepingBuff_Update_Client_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __SpawnSleepingBuff_Update_Client_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnSleepingBuffSystem_Client.NativeFieldInfoPtr___SpawnSleepingBuff_Update_Client_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnSleepingBuffSystem_Client.NativeFieldInfoPtr___SpawnSleepingBuff_Update_Client_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.SpawnSleepingBuffSystem_Client/ProjectM.<>c__DisplayClass_SpawnSleepingBuff_Update_Client")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_SpawnSleepingBuff_Update_Client
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_Entity_byref_Buff_byref_SpawnSleepingBuff_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnSleepingBuffSystem_Client_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<Translation> _ComponentDataFromEntity_Translation_0;
      [FieldOffset(32)]
      public ComponentDataFromEntity<Rotation> _ComponentDataFromEntity_Rotation_1;
      [FieldOffset(64)]
      public SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(136)]
      public unsafe SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001947, XrefRangeEnd = 1001959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref Buff buff,
        [In] ref SpawnSleepingBuff spawnSleepingBuff)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref buff;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spawnSleepingBuff;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_Entity_byref_Buff_byref_SpawnSleepingBuff_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001959, XrefRangeEnd = 1001961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1001970, RefRangeEnd = 1001971, XrefRangeStart = 1001961, XrefRangeEnd = 1001970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1001978, RefRangeEnd = 1001979, XrefRangeStart = 1001971, XrefRangeEnd = 1001978, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(SpawnSleepingBuffSystem_Client componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnSleepingBuffSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001979, XrefRangeEnd = 1001983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001983, XrefRangeEnd = 1001989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_SpawnSleepingBuff_Update_Client()
      {
        Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client>.NativeClassPtr, "<>c__DisplayClass_SpawnSleepingBuff_Update_Client");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr);
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr__ComponentDataFromEntity_Translation_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, nameof (_ComponentDataFromEntity_Translation_0));
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr__ComponentDataFromEntity_Rotation_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, nameof (_ComponentDataFromEntity_Rotation_1));
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, nameof (_runtimes));
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_Entity_byref_Buff_byref_SpawnSleepingBuff_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, 100677584);
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, 100677585);
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, 100677586);
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnSleepingBuffSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, 100677587);
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, 100677588);
        SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, 100677589);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spawnSleepingBuff;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnSleepingBuffSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<Buff> forParameter_buff;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SpawnSleepingBuff> forParameter_spawnSleepingBuff;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1001863, RefRangeEnd = 1001864, XrefRangeStart = 1001856, XrefRangeEnd = 1001863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(SpawnSleepingBuffSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnSleepingBuffSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1001871, RefRangeEnd = 1001872, XrefRangeStart = 1001864, XrefRangeEnd = 1001871, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_buff));
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spawnSleepingBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spawnSleepingBuff));
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_SpawnSleepingBuffSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders>.NativeClassPtr, 100677590);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders>.NativeClassPtr, 100677591);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_buff;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spawnSleepingBuff;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<Buff>.Runtime runtime_buff;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<SpawnSleepingBuff>.Runtime runtime_spawnSleepingBuff;

          static Runtimes()
          {
            Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_buff));
            SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spawnSleepingBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spawnSleepingBuff));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.SpawnSleepingBuffSystem_Client/ProjectM.<>c__DisplayClass_SpawnSleepingBuff_Update_Client/ProjectM.RunWithoutJobSystem_000035FF$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, "RunWithoutJobSystem_000035FF$PostfixBurstDelegate");
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677592);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677593);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677594);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100677595);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.SpawnSleepingBuffSystem_Client/ProjectM.<>c__DisplayClass_SpawnSleepingBuff_Update_Client/ProjectM.RunWithoutJobSystem_000035FF$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001872, XrefRangeEnd = 1001886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001886, XrefRangeEnd = 1001904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001904, XrefRangeEnd = 1001919, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1001946, RefRangeEnd = 1001947, XrefRangeStart = 1001919, XrefRangeEnd = 1001946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client>.NativeClassPtr, "RunWithoutJobSystem_000035FF$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677596);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677597);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677598);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677599);
          SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100677601);
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
            IL2CPP.il2cpp_field_static_get_value(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(SpawnSleepingBuffSystem_Client.__c__DisplayClass_SpawnSleepingBuff_Update_Client.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
