// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.Placement.DestroyCastleHeartSystem_Client
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM.CastleBuilding.Placement
{
  public class DestroyCastleHeartSystem_Client : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___DeserializeCastleHearts_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___DeserializeCastleHearts_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_CastleHeart_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201812, XrefRangeEnd = 1201825, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyCastleHeartSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DestroyCastleHeartSystem_Client()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _OnUpdate_b__0_0(Entity entity, ref CastleHeart castleHeart)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_CastleHeart_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201825, XrefRangeEnd = 1201861, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DestroyCastleHeartSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201861, XrefRangeEnd = 1201880, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForDeserializeCastleHearts_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1201884, RefRangeEnd = 1201885, XrefRangeStart = 1201880, XrefRangeEnd = 1201884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DestroyCastleHeartSystem_Client()
    {
      Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding.Placement", nameof (DestroyCastleHeartSystem_Client));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr);
      DestroyCastleHeartSystem_Client.NativeFieldInfoPtr___DeserializeCastleHearts_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, "<>DeserializeCastleHearts_entityQuery");
      DestroyCastleHeartSystem_Client.NativeFieldInfoPtr___DeserializeCastleHearts_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, "<>DeserializeCastleHearts_profilerMarker");
      DestroyCastleHeartSystem_Client.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, 100664411);
      DestroyCastleHeartSystem_Client.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, 100664412);
      DestroyCastleHeartSystem_Client.NativeMethodInfoPtr__OnUpdate_b__0_0_Private_Void_Entity_byref_CastleHeart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, 100664413);
      DestroyCastleHeartSystem_Client.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, 100664414);
      DestroyCastleHeartSystem_Client.NativeMethodInfoPtr___GetEntityQuery_ForDeserializeCastleHearts_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, 100664415);
      DestroyCastleHeartSystem_Client.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, 100664416);
    }

    public DestroyCastleHeartSystem_Client(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery __DeserializeCastleHearts_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyCastleHeartSystem_Client.NativeFieldInfoPtr___DeserializeCastleHearts_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyCastleHeartSystem_Client.NativeFieldInfoPtr___DeserializeCastleHearts_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __DeserializeCastleHearts_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyCastleHeartSystem_Client.NativeFieldInfoPtr___DeserializeCastleHearts_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DestroyCastleHeartSystem_Client.NativeFieldInfoPtr___DeserializeCastleHearts_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.Placement.DestroyCastleHeartSystem_Client/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_DeserializeCastleHearts")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_DeserializeCastleHearts
    {
      private static readonly System.IntPtr NativeFieldInfoPtr__ComponentDataFromEntity_CastleTerritory_0;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_Entity_byref_CastleHeart_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyCastleHeartSystem_Client_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public ComponentDataFromEntity<CastleTerritory> _ComponentDataFromEntity_CastleTerritory_0;
      [FieldOffset(32)]
      public DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(72)]
      public unsafe DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201777, XrefRangeEnd = 1201788, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(Entity entity, ref CastleHeart castleHeart)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref castleHeart;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_Entity_byref_CastleHeart_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201788, XrefRangeEnd = 1201790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1201796, RefRangeEnd = 1201797, XrefRangeStart = 1201790, XrefRangeEnd = 1201796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1201801, RefRangeEnd = 1201802, XrefRangeStart = 1201797, XrefRangeEnd = 1201801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(DestroyCastleHeartSystem_Client componentSystem)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyCastleHeartSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201802, XrefRangeEnd = 1201806, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201806, XrefRangeEnd = 1201812, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_DeserializeCastleHearts()
      {
        Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client>.NativeClassPtr, "<>c__DisplayClass_DeserializeCastleHearts");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr);
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr__ComponentDataFromEntity_CastleTerritory_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (_ComponentDataFromEntity_CastleTerritory_0));
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (_runtimes));
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_OriginalLambdaBody_Private_Void_Entity_byref_CastleHeart_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100664417);
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100664418);
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100664419);
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyCastleHeartSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100664420);
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100664421);
        DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, 100664422);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_castleHeart;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyCastleHeartSystem_Client_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<CastleHeart> forParameter_castleHeart;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1201696, RefRangeEnd = 1201697, XrefRangeStart = 1201692, XrefRangeEnd = 1201696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DestroyCastleHeartSystem_Client componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyCastleHeartSystem_Client_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1201701, RefRangeEnd = 1201702, XrefRangeStart = 1201697, XrefRangeEnd = 1201701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_castleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_castleHeart));
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DestroyCastleHeartSystem_Client_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100664423);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, 100664424);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_castleHeart;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<CastleHeart>.Runtime runtime_castleHeart;

          static Runtimes()
          {
            Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_castleHeart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_castleHeart));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Placement.DestroyCastleHeartSystem_Client/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_DeserializeCastleHearts/ProjectM.CastleBuilding.Placement.RunWithoutJobSystem_00000308$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_00000308$PostfixBurstDelegate");
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664425);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664426);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664427);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100664428);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.Placement.DestroyCastleHeartSystem_Client/ProjectM.CastleBuilding.Placement.<>c__DisplayClass_DeserializeCastleHearts/ProjectM.CastleBuilding.Placement.RunWithoutJobSystem_00000308$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201702, XrefRangeEnd = 1201716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201716, XrefRangeEnd = 1201734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1201734, XrefRangeEnd = 1201749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1201776, RefRangeEnd = 1201777, XrefRangeStart = 1201749, XrefRangeEnd = 1201776, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts>.NativeClassPtr, "RunWithoutJobSystem_00000308$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664429);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664430);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664431);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664432);
          DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100664434);
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
            IL2CPP.il2cpp_field_static_get_value(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DestroyCastleHeartSystem_Client.__c__DisplayClass_DeserializeCastleHearts.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
