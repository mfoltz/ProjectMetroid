// Decompiled with JetBrains decompiler
// Type: ProjectM.DropItemThrowSystem_Destroy
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public class DropItemThrowSystem_Destroy : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabCollectionSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__GameDataSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateDropItemThrowsJob_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___UpdateDropItemThrowsJob_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForUpdateDropItemThrowsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015387, XrefRangeEnd = 1015403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropItemThrowSystem_Destroy.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015403, XrefRangeEnd = 1015419, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropItemThrowSystem_Destroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropItemThrowSystem_Destroy()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015419, XrefRangeEnd = 1015437, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DropItemThrowSystem_Destroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1015459, RefRangeEnd = 1015460, XrefRangeStart = 1015437, XrefRangeEnd = 1015459, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForUpdateDropItemThrowsJob_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.NativeMethodInfoPtr___GetEntityQuery_ForUpdateDropItemThrowsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1015464, RefRangeEnd = 1015465, XrefRangeStart = 1015460, XrefRangeEnd = 1015464, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DropItemThrowSystem_Destroy()
    {
      Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropItemThrowSystem_Destroy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr);
      DropItemThrowSystem_Destroy.NativeFieldInfoPtr__PrefabCollectionSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, nameof (_PrefabCollectionSystem));
      DropItemThrowSystem_Destroy.NativeFieldInfoPtr__GameDataSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, nameof (_GameDataSystem));
      DropItemThrowSystem_Destroy.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, nameof (_SpawnBarrier));
      DropItemThrowSystem_Destroy.NativeFieldInfoPtr___UpdateDropItemThrowsJob_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, "<>UpdateDropItemThrowsJob_entityQuery");
      DropItemThrowSystem_Destroy.NativeFieldInfoPtr___UpdateDropItemThrowsJob_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, "<>UpdateDropItemThrowsJob_profilerMarker");
      DropItemThrowSystem_Destroy.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, 100679154);
      DropItemThrowSystem_Destroy.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, 100679155);
      DropItemThrowSystem_Destroy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, 100679156);
      DropItemThrowSystem_Destroy.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, 100679157);
      DropItemThrowSystem_Destroy.NativeMethodInfoPtr___GetEntityQuery_ForUpdateDropItemThrowsJob_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, 100679158);
      DropItemThrowSystem_Destroy.NativeMethodInfoPtr_Method_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, 100679159);
    }

    public DropItemThrowSystem_Destroy(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabCollectionSystem _PrefabCollectionSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr__PrefabCollectionSystem));
        return pointer == System.IntPtr.Zero ? (PrefabCollectionSystem) null : new PrefabCollectionSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr__PrefabCollectionSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameDataSystem _GameDataSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr__GameDataSystem));
        return pointer == System.IntPtr.Zero ? (GameDataSystem) null : new GameDataSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr__GameDataSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __UpdateDropItemThrowsJob_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr___UpdateDropItemThrowsJob_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr___UpdateDropItemThrowsJob_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __UpdateDropItemThrowsJob_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr___UpdateDropItemThrowsJob_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropItemThrowSystem_Destroy.NativeFieldInfoPtr___UpdateDropItemThrowsJob_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.DropItemThrowSystem_Destroy/<>c__DisplayClass4_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass4_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_itemLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropItem_byref_SpellMovement_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, ItemData> itemLookupMap;
      [FieldOffset(16)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(64)]
      public EntityCommandBuffer spawnCommandBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass4_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        [In] ref DropItemThrowSystem.DropItem dropItem,
        [In] ref SpellMovement spellMovement)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropItem;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMovement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropItem_byref_SpellMovement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass4_0()
      {
        Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, "<>c__DisplayClass4_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass4_0>.NativeClassPtr);
        DropItemThrowSystem_Destroy.__c__DisplayClass4_0.NativeFieldInfoPtr_itemLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass4_0>.NativeClassPtr, nameof (itemLookupMap));
        DropItemThrowSystem_Destroy.__c__DisplayClass4_0.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass4_0>.NativeClassPtr, nameof (prefabLookupMap));
        DropItemThrowSystem_Destroy.__c__DisplayClass4_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass4_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        DropItemThrowSystem_Destroy.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass4_0>.NativeClassPtr, 100679160);
        DropItemThrowSystem_Destroy.__c__DisplayClass4_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DropItem_byref_SpellMovement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass4_0>.NativeClassPtr, 100679161);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass4_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DropItemThrowSystem_Destroy/ProjectM.<>c__DisplayClass_UpdateDropItemThrowsJob")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_UpdateDropItemThrowsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_itemLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_prefabLookupMap;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropItem_byref_SpellMovement_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_Destroy_byref___c__DisplayClass4_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public NativeHashMap<PrefabGUID, ItemData> itemLookupMap;
      [FieldOffset(16)]
      public PrefabLookupMap prefabLookupMap;
      [FieldOffset(64)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(80)]
      public DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(152)]
      public unsafe DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015315, XrefRangeEnd = 1015360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        [In] ref DropItemThrowSystem.DropItem dropItem,
        [In] ref SpellMovement spellMovement)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[3];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref dropItem;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref spellMovement;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropItem_byref_SpellMovement_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015360, RefRangeEnd = 1015361, XrefRangeStart = 1015360, XrefRangeEnd = 1015360, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref DropItemThrowSystem_Destroy.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015361, RefRangeEnd = 1015362, XrefRangeStart = 1015361, XrefRangeEnd = 1015361, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref DropItemThrowSystem_Destroy.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015362, XrefRangeEnd = 1015364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015373, RefRangeEnd = 1015374, XrefRangeStart = 1015364, XrefRangeEnd = 1015373, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1015376, RefRangeEnd = 1015377, XrefRangeStart = 1015374, XrefRangeEnd = 1015376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        DropItemThrowSystem_Destroy componentSystem,
        ref DropItemThrowSystem_Destroy.__c__DisplayClass4_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_Destroy_byref___c__DisplayClass4_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015377, XrefRangeEnd = 1015381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015381, XrefRangeEnd = 1015387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_UpdateDropItemThrowsJob()
      {
        Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem_Destroy>.NativeClassPtr, "<>c__DisplayClass_UpdateDropItemThrowsJob");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr);
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_itemLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, nameof (itemLookupMap));
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_prefabLookupMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, nameof (prefabLookupMap));
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, nameof (spawnCommandBuffer));
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, nameof (_runtimes));
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DropItem_byref_SpellMovement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, 100679162);
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, 100679163);
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, 100679164);
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, 100679165);
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, 100679166);
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_Destroy_byref___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, 100679167);
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, 100679168);
        DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, 100679169);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_dropItem;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_spellMovement;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_Destroy_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<DropItemThrowSystem.DropItem> forParameter_dropItem;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_IComponentData<SpellMovement> forParameter_spellMovement;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1015231, RefRangeEnd = 1015232, XrefRangeStart = 1015224, XrefRangeEnd = 1015231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(DropItemThrowSystem_Destroy componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_Destroy_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1015239, RefRangeEnd = 1015240, XrefRangeStart = 1015232, XrefRangeEnd = 1015239, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_dropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_dropItem));
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_spellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_spellMovement));
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_DropItemThrowSystem_Destroy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679170);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, 100679171);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_dropItem;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_spellMovement;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<DropItemThrowSystem.DropItem>.Runtime runtime_dropItem;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_IComponentData<SpellMovement>.Runtime runtime_spellMovement;

          static Runtimes()
          {
            Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_dropItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_dropItem));
            DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_spellMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_spellMovement));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.DropItemThrowSystem_Destroy/ProjectM.<>c__DisplayClass_UpdateDropItemThrowsJob/ProjectM.RunWithoutJobSystem_00003A93$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, "RunWithoutJobSystem_00003A93$PostfixBurstDelegate");
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679172);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679173);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679174);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100679175);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.DropItemThrowSystem_Destroy/ProjectM.<>c__DisplayClass_UpdateDropItemThrowsJob/ProjectM.RunWithoutJobSystem_00003A93$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015240, XrefRangeEnd = 1015254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015254, XrefRangeEnd = 1015272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015272, XrefRangeEnd = 1015287, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1015314, RefRangeEnd = 1015315, XrefRangeStart = 1015287, XrefRangeEnd = 1015314, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob>.NativeClassPtr, "RunWithoutJobSystem_00003A93$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679176);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679177);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679178);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679179);
          DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100679181);
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
            IL2CPP.il2cpp_field_static_get_value(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(DropItemThrowSystem_Destroy.__c__DisplayClass_UpdateDropItemThrowsJob.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
