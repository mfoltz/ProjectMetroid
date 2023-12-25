// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleBuildingAttachmentCleanup
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
namespace ProjectM.CastleBuilding
{
  public class CastleBuildingAttachmentCleanup : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__SpawnBarrier;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenChildDestroyed_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenChildDestroyed_profilerMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenParentDestroyed_entityQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenParentDestroyed_profilerMarker;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingAttachmentsWhenChildDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingAttachmentsWhenParentDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193954, XrefRangeEnd = 1193960, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193960, XrefRangeEnd = 1193995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleBuildingAttachmentCleanup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193995, XrefRangeEnd = 1194065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194065, XrefRangeEnd = 1194084, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCleanupCastleBuildingAttachmentsWhenChildDestroyed_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingAttachmentsWhenChildDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194084, XrefRangeEnd = 1194103, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForCleanupCastleBuildingAttachmentsWhenParentDestroyed_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingAttachmentsWhenParentDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194103, XrefRangeEnd = 1194107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_0()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194107, XrefRangeEnd = 1194111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Method_Public_Static_Void_PDM_1()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleBuildingAttachmentCleanup()
    {
      Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (CastleBuildingAttachmentCleanup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr);
      CastleBuildingAttachmentCleanup.NativeFieldInfoPtr__SpawnBarrier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, nameof (_SpawnBarrier));
      CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenChildDestroyed_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, "<>CleanupCastleBuildingAttachmentsWhenChildDestroyed_entityQuery");
      CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenChildDestroyed_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, "<>CleanupCastleBuildingAttachmentsWhenChildDestroyed_profilerMarker");
      CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenParentDestroyed_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, "<>CleanupCastleBuildingAttachmentsWhenParentDestroyed_entityQuery");
      CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenParentDestroyed_profilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, "<>CleanupCastleBuildingAttachmentsWhenParentDestroyed_profilerMarker");
      CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, 100663664);
      CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, 100663665);
      CastleBuildingAttachmentCleanup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, 100663666);
      CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, 100663667);
      CastleBuildingAttachmentCleanup.NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingAttachmentsWhenChildDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, 100663668);
      CastleBuildingAttachmentCleanup.NativeMethodInfoPtr___GetEntityQuery_ForCleanupCastleBuildingAttachmentsWhenParentDestroyed_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, 100663669);
      CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, 100663670);
      CastleBuildingAttachmentCleanup.NativeMethodInfoPtr_Method_Public_Static_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, 100663671);
    }

    public CastleBuildingAttachmentCleanup(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SpawnBarrier _SpawnBarrier
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr__SpawnBarrier));
        return pointer == System.IntPtr.Zero ? (SpawnBarrier) null : new SpawnBarrier(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr__SpawnBarrier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery __CleanupCastleBuildingAttachmentsWhenChildDestroyed_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenChildDestroyed_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenChildDestroyed_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CleanupCastleBuildingAttachmentsWhenChildDestroyed_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenChildDestroyed_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenChildDestroyed_profilerMarker)) = value;
      }
    }

    public unsafe EntityQuery __CleanupCastleBuildingAttachmentsWhenParentDestroyed_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenParentDestroyed_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenParentDestroyed_entityQuery)) = value;
      }
    }

    public unsafe ProfilerMarker __CleanupCastleBuildingAttachmentsWhenParentDestroyed_profilerMarker
    {
      get
      {
        return *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenParentDestroyed_profilerMarker));
      }
      [param: In] set
      {
        *(ProfilerMarker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastleBuildingAttachmentCleanup.NativeFieldInfoPtr___CleanupCastleBuildingAttachmentsWhenParentDestroyed_profilerMarker)) = value;
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingAttachmentCleanup/<>c__DisplayClass2_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass2_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getChildrenBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_getAttachToParentsBuffer;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachToParentsBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachedChildrenBuffer_0;
      [FieldOffset(0)]
      public BufferFromEntity<CastleBuildingAttachedChildrenBuffer> getChildrenBuffer;
      [FieldOffset(40)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(56)]
      public BufferFromEntity<CastleBuildingAttachToParentsBuffer> getAttachToParentsBuffer;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass2_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity childEntity,
        ref DynamicBuffer<CastleBuildingAttachToParentsBuffer> parentsBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &childEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parentsBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachToParentsBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(
        Entity parentEntity,
        ref DynamicBuffer<CastleBuildingAttachedChildrenBuffer> childrenBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &parentEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref childrenBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachedChildrenBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass2_0()
      {
        Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, "<>c__DisplayClass2_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr);
        CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeFieldInfoPtr_getChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr, nameof (getChildrenBuffer));
        CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr, nameof (spawnCommandBuffer));
        CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeFieldInfoPtr_getAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr, nameof (getAttachToParentsBuffer));
        CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr, 100663672);
        CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachToParentsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr, 100663673);
        CastleBuildingAttachmentCleanup.__c__DisplayClass2_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachedChildrenBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr, 100663674);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass2_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingAttachmentCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getChildrenBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachToParentsBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BufferFromEntity<CastleBuildingAttachedChildrenBuffer> getChildrenBuffer;
      [FieldOffset(40)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(56)]
      public CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193747, XrefRangeEnd = 1193785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity childEntity,
        ref DynamicBuffer<CastleBuildingAttachToParentsBuffer> parentsBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &childEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref parentsBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachToParentsBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1014210, RefRangeEnd = 1014213, XrefRangeStart = 1014210, XrefRangeEnd = 1014213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleBuildingAttachmentCleanup.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(3)]
      [CachedScanResults(RefRangeStart = 1014213, RefRangeEnd = 1014216, XrefRangeStart = 1014213, XrefRangeEnd = 1014216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleBuildingAttachmentCleanup.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193785, XrefRangeEnd = 1193787, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1193793, RefRangeEnd = 1193794, XrefRangeStart = 1193787, XrefRangeEnd = 1193793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1193796, RefRangeEnd = 1193797, XrefRangeStart = 1193794, XrefRangeEnd = 1193796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleBuildingAttachmentCleanup componentSystem,
        ref CastleBuildingAttachmentCleanup.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193797, XrefRangeEnd = 1193801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193801, XrefRangeEnd = 1193807, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed()
      {
        Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, "<>c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr_getChildrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, nameof (getChildrenBuffer));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, nameof (spawnCommandBuffer));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, nameof (_runtimes));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachToParentsBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, 100663675);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, 100663676);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, 100663677);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, 100663678);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, 100663679);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, 100663680);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, 100663681);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, 100663682);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_childEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_parentsBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_childEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<CastleBuildingAttachToParentsBuffer> forParameter_parentsBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1193666, RefRangeEnd = 1193667, XrefRangeStart = 1193662, XrefRangeEnd = 1193666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleBuildingAttachmentCleanup componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1193671, RefRangeEnd = 1193672, XrefRangeStart = 1193667, XrefRangeEnd = 1193671, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_childEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_childEntity));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_parentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_parentsBuffer));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders>.NativeClassPtr, 100663683);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders>.NativeClassPtr, 100663684);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_childEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_parentsBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_childEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<CastleBuildingAttachToParentsBuffer>.Runtime runtime_parentsBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_childEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_childEntity));
            CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_parentsBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingAttachmentCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed/ProjectM.CastleBuilding.RunWithoutJobSystem_0000011F$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, "RunWithoutJobSystem_0000011F$PostfixBurstDelegate");
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663685);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663686);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663687);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663688);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingAttachmentCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed/ProjectM.CastleBuilding.RunWithoutJobSystem_0000011F$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193672, XrefRangeEnd = 1193686, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193686, XrefRangeEnd = 1193704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193704, XrefRangeEnd = 1193719, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1193746, RefRangeEnd = 1193747, XrefRangeStart = 1193719, XrefRangeEnd = 1193746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed>.NativeClassPtr, "RunWithoutJobSystem_0000011F$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663689);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663690);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663691);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663692);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663694);
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
            IL2CPP.il2cpp_field_static_get_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenChildDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingAttachmentCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getAttachToParentsBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_spawnCommandBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst;
      private static readonly System.IntPtr NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachedChildrenBuffer_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_byref___c__DisplayClass2_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0;
      [FieldOffset(0)]
      public BufferFromEntity<CastleBuildingAttachToParentsBuffer> getAttachToParentsBuffer;
      [FieldOffset(40)]
      public EntityCommandBuffer spawnCommandBuffer;
      [FieldOffset(56)]
      public CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(104)]
      public unsafe CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193892, XrefRangeEnd = 1193930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity parentEntity,
        ref DynamicBuffer<CastleBuildingAttachedChildrenBuffer> childrenBuffer)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &parentEntity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref childrenBuffer;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachedChildrenBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1193930, RefRangeEnd = 1193931, XrefRangeStart = 1193930, XrefRangeEnd = 1193930, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref CastleBuildingAttachmentCleanup.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1193931, RefRangeEnd = 1193932, XrefRangeStart = 1193931, XrefRangeEnd = 1193931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void WriteToDisplayClass(
        ref CastleBuildingAttachmentCleanup.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193932, XrefRangeEnd = 1193934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1193940, RefRangeEnd = 1193941, XrefRangeStart = 1193934, XrefRangeEnd = 1193940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1193943, RefRangeEnd = 1193944, XrefRangeStart = 1193941, XrefRangeEnd = 1193943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        CastleBuildingAttachmentCleanup componentSystem,
        ref CastleBuildingAttachmentCleanup.__c__DisplayClass2_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_byref___c__DisplayClass2_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193944, XrefRangeEnd = 1193948, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void RunWithoutJobSystem(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193948, XrefRangeEnd = 1193954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe void Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0(
        ArchetypeChunkIterator* archetypeChunkIterator,
        void* jobData)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed()
      {
        Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup>.NativeClassPtr, "<>c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr_getAttachToParentsBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, nameof (getAttachToParentsBuffer));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr_spawnCommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, nameof (spawnCommandBuffer));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, nameof (_runtimes));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldNoBurst));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, nameof (s_RunWithoutJobSystemDelegateFieldBurst));
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DynamicBuffer_1_CastleBuildingAttachedChildrenBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, 100663695);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, 100663696);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_WriteToDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, 100663697);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, 100663698);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, 100663699);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_byref___c__DisplayClass2_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, 100663700);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_RunWithoutJobSystem_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, 100663701);
        CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeMethodInfoPtr_Method_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, 100663702);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, (System.IntPtr) ref this));
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldNoBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldNoBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate s_RunWithoutJobSystemDelegateFieldBurst
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate) null : new InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.NativeFieldInfoPtr_s_RunWithoutJobSystemDelegateFieldBurst, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_parentEntity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_childrenBuffer;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_parentEntity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_DynamicBuffer<CastleBuildingAttachedChildrenBuffer> forParameter_childrenBuffer;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1193811, RefRangeEnd = 1193812, XrefRangeStart = 1193807, XrefRangeEnd = 1193811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(CastleBuildingAttachmentCleanup componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1193816, RefRangeEnd = 1193817, XrefRangeStart = 1193812, XrefRangeEnd = 1193816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_parentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_parentEntity));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_childrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_childrenBuffer));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_CastleBuildingAttachmentCleanup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders>.NativeClassPtr, 100663703);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders>.NativeClassPtr, 100663704);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_parentEntity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_childrenBuffer;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_parentEntity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_DynamicBuffer<CastleBuildingAttachedChildrenBuffer>.Runtime runtime_childrenBuffer;

          static Runtimes()
          {
            Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_parentEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_parentEntity));
            CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_childrenBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_childrenBuffer));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingAttachmentCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed/ProjectM.CastleBuilding.RunWithoutJobSystem_00000128$PostfixBurstDelegate")]
      public sealed class MulticastDelegateNPublicSealedVoObObUnique : Il2CppSystem.MulticastDelegate
      {
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

        [CallerCount(5227)]
        [CachedScanResults(RefRangeStart = 23798, RefRangeEnd = 29025, XrefRangeStart = 23798, XrefRangeEnd = 29025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe MulticastDelegateNPublicSealedVoObObUnique(Il2CppSystem.Object _param1, System.IntPtr _param2)
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr))
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &_param2;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static MulticastDelegateNPublicSealedVoObObUnique()
        {
          Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, "RunWithoutJobSystem_00000128$PostfixBurstDelegate");
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663705);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663706);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ptr_ArchetypeChunkIterator_ptr_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663707);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.MulticastDelegateNPublicSealedVoObObUnique>.NativeClassPtr, 100663708);
        }

        public MulticastDelegateNPublicSealedVoObObUnique(System.IntPtr pointer)
          : base(pointer)
        {
        }
      }

      [ObfuscatedName("ProjectM.CastleBuilding.CastleBuildingAttachmentCleanup/ProjectM.CastleBuilding.<>c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed/ProjectM.CastleBuilding.RunWithoutJobSystem_00000128$BurstDirectCall")]
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
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193817, XrefRangeEnd = 1193831, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void GetFunctionPointerDiscard(ref System.IntPtr _param0)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = (System.IntPtr) ref _param0;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193831, XrefRangeEnd = 1193849, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe System.IntPtr GetFunctionPointer()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
        }

        [CallerCount(0)]
        [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1193849, XrefRangeEnd = 1193864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Constructor()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(10560)]
        [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Initialize()
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1193891, RefRangeEnd = 1193892, XrefRangeStart = 1193864, XrefRangeEnd = 1193891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public static unsafe void Invoke(
          ArchetypeChunkIterator* archetypeChunkIterator,
          void* jobData)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[2];
          numPtr[0] = (System.IntPtr) (void*) archetypeChunkIterator;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) jobData;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static ObjectNInternalAbstractSealedInPoDeInUnique()
        {
          Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed>.NativeClassPtr, "RunWithoutJobSystem_00000128$BurstDirectCall");
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (Pointer));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, nameof (DeferredCompilation));
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointerDiscard_Private_Static_Void_byref_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663709);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_GetFunctionPointer_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663710);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Constructor_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663711);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663712);
          CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeMethodInfoPtr_Invoke_Public_Static_Void_ptr_ArchetypeChunkIterator_ptr_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique>.NativeClassPtr, 100663714);
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
            IL2CPP.il2cpp_field_static_get_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &pointer);
            return pointer;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_Pointer, (void*) &value);
          }
        }

        public static unsafe System.IntPtr DeferredCompilation
        {
          get
          {
            System.IntPtr deferredCompilation;
            IL2CPP.il2cpp_field_static_get_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &deferredCompilation);
            return deferredCompilation;
          }
          [param: In] set
          {
            IL2CPP.il2cpp_field_static_set_value(CastleBuildingAttachmentCleanup.__c__DisplayClass_CleanupCastleBuildingAttachmentsWhenParentDestroyed.ObjectNInternalAbstractSealedInPoDeInUnique.NativeFieldInfoPtr_DeferredCompilation, (void*) &value);
          }
        }
      }
    }
  }
}
