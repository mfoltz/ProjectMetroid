// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowTileCollisionHistorySystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  public class ShowTileCollisionHistorySystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__NewPreviewQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__CleanupPreviewQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__WorldFrame;
    private static readonly System.IntPtr NativeFieldInfoPtr___ShowTileCollisionHistory_entityQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr___GetEntityQuery_ForShowTileCollisionHistory_From_Public_Static_EntityQuery_ComponentSystemBase_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074820, XrefRangeEnd = 1074843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileCollisionHistorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074843, XrefRangeEnd = 1074846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileCollisionHistorySystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074846, XrefRangeEnd = 1074897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileCollisionHistorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowTileCollisionHistorySystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074897, XrefRangeEnd = 1074899, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileCollisionHistorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1074927, RefRangeEnd = 1074930, XrefRangeStart = 1074899, XrefRangeEnd = 1074927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQuery __GetEntityQuery_ForShowTileCollisionHistory_From(
      ComponentSystemBase componentSystem)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.NativeMethodInfoPtr___GetEntityQuery_ForShowTileCollisionHistory_From_Public_Static_EntityQuery_ComponentSystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ShowTileCollisionHistorySystem()
    {
      Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShowTileCollisionHistorySystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr);
      ShowTileCollisionHistorySystem.NativeFieldInfoPtr__NewPreviewQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, nameof (_NewPreviewQuery));
      ShowTileCollisionHistorySystem.NativeFieldInfoPtr__CleanupPreviewQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, nameof (_CleanupPreviewQuery));
      ShowTileCollisionHistorySystem.NativeFieldInfoPtr__WorldFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, nameof (_WorldFrame));
      ShowTileCollisionHistorySystem.NativeFieldInfoPtr___ShowTileCollisionHistory_entityQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, "<>ShowTileCollisionHistory_entityQuery");
      ShowTileCollisionHistorySystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, 100684679);
      ShowTileCollisionHistorySystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, 100684680);
      ShowTileCollisionHistorySystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, 100684681);
      ShowTileCollisionHistorySystem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, 100684682);
      ShowTileCollisionHistorySystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, 100684683);
      ShowTileCollisionHistorySystem.NativeMethodInfoPtr___GetEntityQuery_ForShowTileCollisionHistory_From_Public_Static_EntityQuery_ComponentSystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, 100684684);
    }

    public ShowTileCollisionHistorySystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _NewPreviewQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollisionHistorySystem.NativeFieldInfoPtr__NewPreviewQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollisionHistorySystem.NativeFieldInfoPtr__NewPreviewQuery)) = value;
      }
    }

    public unsafe EntityQuery _CleanupPreviewQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollisionHistorySystem.NativeFieldInfoPtr__CleanupPreviewQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollisionHistorySystem.NativeFieldInfoPtr__CleanupPreviewQuery)) = value;
      }
    }

    public unsafe SingletonAccessor<WorldFrame> _WorldFrame
    {
      get
      {
        return *(SingletonAccessor<WorldFrame>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollisionHistorySystem.NativeFieldInfoPtr__WorldFrame));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollisionHistorySystem.NativeFieldInfoPtr__WorldFrame), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SingletonAccessor<WorldFrame>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe EntityQuery __ShowTileCollisionHistory_entityQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollisionHistorySystem.NativeFieldInfoPtr___ShowTileCollisionHistory_entityQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileCollisionHistorySystem.NativeFieldInfoPtr___ShowTileCollisionHistory_entityQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ShowTileCollisionHistoryActive
    {
      static ShowTileCollisionHistoryActive()
      {
        Il2CppClassPointerStore<ShowTileCollisionHistorySystem.ShowTileCollisionHistoryActive>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, nameof (ShowTileCollisionHistoryActive));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.ShowTileCollisionHistoryActive>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.ShowTileCollisionHistoryActive>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ShowTileCollisionHistorySystem/<>c__DisplayClass6_0")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass6_0
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getColoredGridBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DrawGrid_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_Translation_0;
      [FieldOffset(0)]
      public BufferFromEntity<DrawGridBuffer> getColoredGridBuffer;
      [FieldOffset(40)]
      public int currentFrame;

      [CallerCount(10560)]
      [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(
        Entity entity,
        ref DrawGrid showGrid,
        [In] ref DynamicBuffer<TileCollisionHistoryElement> tileCollisionHistoryBuffer,
        [In] ref DynamicBuffer<TileCollisionHistoryMetadataElement> tileCollisionHistoryMetadataBuffer,
        [In] ref Translation tranlation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref showGrid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionHistoryBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionHistoryMetadataBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tranlation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DrawGrid_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass6_0>.NativeClassPtr);
        ShowTileCollisionHistorySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_getColoredGridBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (getColoredGridBuffer));
        ShowTileCollisionHistorySystem.__c__DisplayClass6_0.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (currentFrame));
        ShowTileCollisionHistorySystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass6_0>.NativeClassPtr, 100684685);
        ShowTileCollisionHistorySystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_Entity_byref_DrawGrid_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass6_0>.NativeClassPtr, 100684686);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass6_0>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ShowTileCollisionHistorySystem/ProjectM.<>c__DisplayClass_ShowTileCollisionHistory")]
    [StructLayout(LayoutKind.Explicit)]
    public struct __c__DisplayClass_ShowTileCollisionHistory
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_getColoredGridBuffer;
      private static readonly System.IntPtr NativeFieldInfoPtr_currentFrame;
      private static readonly System.IntPtr NativeFieldInfoPtr__lambdaParameterValueProviders;
      private static readonly System.IntPtr NativeFieldInfoPtr__runtimes;
      private static readonly System.IntPtr NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DrawGrid_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_Translation_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowTileCollisionHistorySystem_byref___c__DisplayClass6_0_0;
      [FieldOffset(0)]
      public BufferFromEntity<DrawGridBuffer> getColoredGridBuffer;
      [FieldOffset(40)]
      public int currentFrame;
      [FieldOffset(48)]
      public ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders _lambdaParameterValueProviders;
      [FieldOffset(200)]
      public unsafe ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes* _runtimes;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074768, XrefRangeEnd = 1074797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void OriginalLambdaBody(
        Entity entity,
        ref DrawGrid showGrid,
        [In] ref DynamicBuffer<TileCollisionHistoryElement> tileCollisionHistoryBuffer,
        [In] ref DynamicBuffer<TileCollisionHistoryMetadataElement> tileCollisionHistoryMetadataBuffer,
        [In] ref Translation tranlation)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[5];
        numPtr[0] = (System.IntPtr) &entity;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref showGrid;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionHistoryBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref tileCollisionHistoryMetadataBuffer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref tranlation;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DrawGrid_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_Translation_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1074797, RefRangeEnd = 1074799, XrefRangeStart = 1074797, XrefRangeEnd = 1074797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe void ReadFromDisplayClass(
        ref ShowTileCollisionHistorySystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074799, XrefRangeEnd = 1074801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1074816, RefRangeEnd = 1074817, XrefRangeStart = 1074801, XrefRangeEnd = 1074816, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void IterateEntities(
        ref ArchetypeChunk chunk,
        ref ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes runtimes)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) ref chunk;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref runtimes;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1074819, RefRangeEnd = 1074820, XrefRangeStart = 1074817, XrefRangeEnd = 1074819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void ScheduleTimeInitialize(
        ShowTileCollisionHistorySystem componentSystem,
        ref ShowTileCollisionHistorySystem.__c__DisplayClass6_0 displayClass)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref displayClass;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowTileCollisionHistorySystem_byref___c__DisplayClass6_0_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass_ShowTileCollisionHistory()
      {
        Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollisionHistorySystem>.NativeClassPtr, "<>c__DisplayClass_ShowTileCollisionHistory");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr);
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeFieldInfoPtr_getColoredGridBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, nameof (getColoredGridBuffer));
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeFieldInfoPtr_currentFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, nameof (currentFrame));
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeFieldInfoPtr__lambdaParameterValueProviders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, nameof (_lambdaParameterValueProviders));
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeFieldInfoPtr__runtimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, nameof (_runtimes));
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_OriginalLambdaBody_Internal_Void_Entity_byref_DrawGrid_byref_DynamicBuffer_1_TileCollisionHistoryElement_byref_DynamicBuffer_1_TileCollisionHistoryMetadataElement_byref_Translation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, 100684687);
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_ReadFromDisplayClass_Public_Virtual_Final_New_Void_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, 100684688);
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, 100684689);
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_IterateEntities_Public_Void_byref_ArchetypeChunk_byref_Runtimes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, 100684690);
        ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowTileCollisionHistorySystem_byref___c__DisplayClass6_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, 100684691);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, (System.IntPtr) ref this));
      }

      [StructLayout(LayoutKind.Explicit)]
      public struct LambdaParameterValueProviders
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_entity;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_showGrid;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tileCollisionHistoryBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tileCollisionHistoryMetadataBuffer;
        private static readonly System.IntPtr NativeFieldInfoPtr_forParameter_tranlation;
        private static readonly System.IntPtr NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowTileCollisionHistorySystem_0;
        private static readonly System.IntPtr NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0;
        [FieldOffset(0)]
        public LambdaParameterValueProvider_Entity forParameter_entity;
        [FieldOffset(8)]
        public LambdaParameterValueProvider_IComponentData<DrawGrid> forParameter_showGrid;
        [FieldOffset(40)]
        public LambdaParameterValueProvider_DynamicBuffer<TileCollisionHistoryElement> forParameter_tileCollisionHistoryBuffer;
        [FieldOffset(80)]
        public LambdaParameterValueProvider_DynamicBuffer<TileCollisionHistoryMetadataElement> forParameter_tileCollisionHistoryMetadataBuffer;
        [FieldOffset(120)]
        public LambdaParameterValueProvider_IComponentData<Translation> forParameter_tranlation;

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1074753, RefRangeEnd = 1074754, XrefRangeStart = 1074740, XrefRangeEnd = 1074753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe void ScheduleTimeInitialize(ShowTileCollisionHistorySystem componentSystem)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[1];
          numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentSystem);
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowTileCollisionHistorySystem_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        [CallerCount(1)]
        [CachedScanResults(RefRangeStart = 1074767, RefRangeEnd = 1074768, XrefRangeStart = 1074754, XrefRangeEnd = 1074767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes PrepareToExecuteOnEntitiesInMethod(
          ref ArchetypeChunk p0,
          int p1,
          int p2)
        {
          System.IntPtr* numPtr = stackalloc System.IntPtr[3];
          numPtr[0] = (System.IntPtr) ref p0;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &p1;
          *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &p2;
          System.IntPtr exc;
          System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes*) IL2CPP.il2cpp_object_unbox(num);
        }

        static LambdaParameterValueProviders()
        {
          Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory>.NativeClassPtr, nameof (LambdaParameterValueProviders));
          ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_entity));
          ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_showGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_showGrid));
          ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tileCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tileCollisionHistoryBuffer));
          ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tileCollisionHistoryMetadataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tileCollisionHistoryMetadataBuffer));
          ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeFieldInfoPtr_forParameter_tranlation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, nameof (forParameter_tranlation));
          ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeMethodInfoPtr_ScheduleTimeInitialize_Public_Void_ShowTileCollisionHistorySystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, 100684692);
          ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.NativeMethodInfoPtr_PrepareToExecuteOnEntitiesInMethod_Public_Runtimes_byref_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, 100684693);
        }

        public Il2CppSystem.Object BoxIl2CppObject()
        {
          return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, (System.IntPtr) ref this));
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct Runtimes
        {
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_entity;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_showGrid;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tileCollisionHistoryBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tileCollisionHistoryMetadataBuffer;
          private static readonly System.IntPtr NativeFieldInfoPtr_runtime_tranlation;
          [FieldOffset(0)]
          public LambdaParameterValueProvider_Entity.Runtime runtime_entity;
          [FieldOffset(8)]
          public LambdaParameterValueProvider_IComponentData<DrawGrid>.Runtime runtime_showGrid;
          [FieldOffset(16)]
          public LambdaParameterValueProvider_DynamicBuffer<TileCollisionHistoryElement>.Runtime runtime_tileCollisionHistoryBuffer;
          [FieldOffset(40)]
          public LambdaParameterValueProvider_DynamicBuffer<TileCollisionHistoryMetadataElement>.Runtime runtime_tileCollisionHistoryMetadataBuffer;
          [FieldOffset(64)]
          public LambdaParameterValueProvider_IComponentData<Translation>.Runtime runtime_tranlation;

          static Runtimes()
          {
            Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders>.NativeClassPtr, nameof (Runtimes));
            ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_entity));
            ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_showGrid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_showGrid));
            ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tileCollisionHistoryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tileCollisionHistoryBuffer));
            ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tileCollisionHistoryMetadataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tileCollisionHistoryMetadataBuffer));
            ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes.NativeFieldInfoPtr_runtime_tranlation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, nameof (runtime_tranlation));
          }

          public Il2CppSystem.Object BoxIl2CppObject()
          {
            return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileCollisionHistorySystem.__c__DisplayClass_ShowTileCollisionHistory.LambdaParameterValueProviders.Runtimes>.NativeClassPtr, (System.IntPtr) ref this));
          }
        }
      }
    }
  }
}
