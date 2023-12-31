// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileWorldSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Jobs;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileWorldSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorld;
    private static readonly System.IntPtr NativeFieldInfoPtr__ReadDependency;
    private static readonly System.IntPtr NativeFieldInfoPtr__WriteDependency;
    private static readonly System.IntPtr NativeFieldInfoPtr__LoadedChunkEventQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr__UnloadedChunkEventQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetWriteable_Public_TileWorldWriteable_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddWriterJobHandle_Public_Void_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddReaderJobHandle_Public_Void_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileWorldAndCompleteDeps_Public_TileWorld_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTileWorldAsync_Public_TileWorld_byref_JobHandle_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 792835, RefRangeEnd = 792838, XrefRangeStart = 792834, XrefRangeEnd = 792835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileWorldWriteable GetWriteable(out JobHandle writeDependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref writeDependency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldSystem.NativeMethodInfoPtr_GetWriteable_Public_TileWorldWriteable_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileWorldWriteable*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 792840, RefRangeEnd = 792842, XrefRangeStart = 792838, XrefRangeEnd = 792840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddWriterJobHandle(JobHandle writeDependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &writeDependency;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldSystem.NativeMethodInfoPtr_AddWriterJobHandle_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(13)]
    [CachedScanResults(RefRangeStart = 792843, RefRangeEnd = 792856, XrefRangeStart = 792842, XrefRangeEnd = 792843, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddReaderJobHandle(JobHandle readDependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &readDependency;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldSystem.NativeMethodInfoPtr_AddReaderJobHandle_Public_Void_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(56)]
    [CachedScanResults(RefRangeStart = 792857, RefRangeEnd = 792913, XrefRangeStart = 792856, XrefRangeEnd = 792857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileWorld GetTileWorldAndCompleteDeps()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldSystem.NativeMethodInfoPtr_GetTileWorldAndCompleteDeps_Public_TileWorld_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 792914, RefRangeEnd = 792922, XrefRangeStart = 792913, XrefRangeEnd = 792914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileWorld GetTileWorldAsync(out JobHandle readDependency)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref readDependency;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileWorldSystem.NativeMethodInfoPtr_GetTileWorldAsync_Public_TileWorld_byref_JobHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TileWorld*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792922, XrefRangeEnd = 792947, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileWorldSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792947, XrefRangeEnd = 792955, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileWorldSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792955, XrefRangeEnd = 792991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileWorldSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileWorldSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileWorldSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileWorldSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileWorldSystem()
    {
      Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Tiles", nameof (TileWorldSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr);
      TileWorldSystem.NativeFieldInfoPtr__TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, nameof (_TileWorld));
      TileWorldSystem.NativeFieldInfoPtr__ReadDependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, nameof (_ReadDependency));
      TileWorldSystem.NativeFieldInfoPtr__WriteDependency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, nameof (_WriteDependency));
      TileWorldSystem.NativeFieldInfoPtr__LoadedChunkEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, nameof (_LoadedChunkEventQuery));
      TileWorldSystem.NativeFieldInfoPtr__UnloadedChunkEventQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, nameof (_UnloadedChunkEventQuery));
      TileWorldSystem.NativeMethodInfoPtr_GetWriteable_Public_TileWorldWriteable_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669806);
      TileWorldSystem.NativeMethodInfoPtr_AddWriterJobHandle_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669807);
      TileWorldSystem.NativeMethodInfoPtr_AddReaderJobHandle_Public_Void_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669808);
      TileWorldSystem.NativeMethodInfoPtr_GetTileWorldAndCompleteDeps_Public_TileWorld_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669809);
      TileWorldSystem.NativeMethodInfoPtr_GetTileWorldAsync_Public_TileWorld_byref_JobHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669810);
      TileWorldSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669811);
      TileWorldSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669812);
      TileWorldSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669813);
      TileWorldSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669814);
      TileWorldSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, 100669815);
    }

    public TileWorldSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TileWorldWriteable _TileWorld
    {
      get
      {
        return *(TileWorldWriteable*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__TileWorld));
      }
      [param: In] set
      {
        *(TileWorldWriteable*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__TileWorld)) = value;
      }
    }

    public unsafe JobHandleManager _ReadDependency
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__ReadDependency));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__ReadDependency)) = value;
      }
    }

    public unsafe JobHandleManager _WriteDependency
    {
      get
      {
        return *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__WriteDependency));
      }
      [param: In] set
      {
        *(JobHandleManager*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__WriteDependency)) = value;
      }
    }

    public unsafe EntityQuery _LoadedChunkEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__LoadedChunkEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__LoadedChunkEventQuery)) = value;
      }
    }

    public unsafe EntityQuery _UnloadedChunkEventQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__UnloadedChunkEventQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileWorldSystem.NativeFieldInfoPtr__UnloadedChunkEventQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ProcessLoadedChunksJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EventTypeHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCellBaseHeightLevels;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBaseHeightLevels;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetChunkBaseGameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsServer;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<TerrainChunkLoadedEvent> EventTypeHandle;
      [FieldOffset(32)]
      public BufferFromEntity<ChunkCellBaseHeightLevel> GetCellBaseHeightLevels;
      [FieldOffset(72)]
      public BufferFromEntity<ChunkTileBaseHeightLevel> GetBaseHeightLevels;
      [FieldOffset(112)]
      public BufferFromEntity<ChunkBaseGameplayHeights> GetChunkBaseGameplayHeights;
      [FieldOffset(152)]
      public TileWorldWriteable TileWorld;
      [FieldOffset(176)]
      public bool IsServer;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792803, XrefRangeEnd = 792829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TileWorldSystem.ProcessLoadedChunksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ProcessLoadedChunksJob()
      {
        Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, nameof (ProcessLoadedChunksJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr);
        TileWorldSystem.ProcessLoadedChunksJob.NativeFieldInfoPtr_EventTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr, nameof (EventTypeHandle));
        TileWorldSystem.ProcessLoadedChunksJob.NativeFieldInfoPtr_GetCellBaseHeightLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr, nameof (GetCellBaseHeightLevels));
        TileWorldSystem.ProcessLoadedChunksJob.NativeFieldInfoPtr_GetBaseHeightLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr, nameof (GetBaseHeightLevels));
        TileWorldSystem.ProcessLoadedChunksJob.NativeFieldInfoPtr_GetChunkBaseGameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr, nameof (GetChunkBaseGameplayHeights));
        TileWorldSystem.ProcessLoadedChunksJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr, nameof (TileWorld));
        TileWorldSystem.ProcessLoadedChunksJob.NativeFieldInfoPtr_IsServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr, nameof (IsServer));
        TileWorldSystem.ProcessLoadedChunksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr, 100669816);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileWorldSystem.ProcessLoadedChunksJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ProcessUnloadedChunksJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_EventTypeHandle;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public ComponentTypeHandle<TerrainChunkUnloadedEvent> EventTypeHandle;
      [FieldOffset(32)]
      public TileWorldWriteable TileWorld;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 792829, XrefRangeEnd = 792834, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(TileWorldSystem.ProcessUnloadedChunksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ProcessUnloadedChunksJob()
      {
        Il2CppClassPointerStore<TileWorldSystem.ProcessUnloadedChunksJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TileWorldSystem>.NativeClassPtr, nameof (ProcessUnloadedChunksJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileWorldSystem.ProcessUnloadedChunksJob>.NativeClassPtr);
        TileWorldSystem.ProcessUnloadedChunksJob.NativeFieldInfoPtr_EventTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem.ProcessUnloadedChunksJob>.NativeClassPtr, nameof (EventTypeHandle));
        TileWorldSystem.ProcessUnloadedChunksJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileWorldSystem.ProcessUnloadedChunksJob>.NativeClassPtr, nameof (TileWorld));
        TileWorldSystem.ProcessUnloadedChunksJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileWorldSystem.ProcessUnloadedChunksJob>.NativeClassPtr, 100669817);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TileWorldSystem.ProcessUnloadedChunksJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
