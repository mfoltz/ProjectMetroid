// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ShowTileHeightsSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Terrain
{
  public class ShowTileHeightsSystem : 
    DrawTileGridSystem<ShowTileHeightsDebug, ShowTileHeightsSystem.GridIsActive>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__DrawQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125242, XrefRangeEnd = 1125257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileHeightsSystem.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125257, XrefRangeEnd = 1125286, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileHeightsSystem.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125286, XrefRangeEnd = 1125289, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowTileHeightsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTileHeightsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125289, XrefRangeEnd = 1125292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileHeightsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowTileHeightsSystem()
    {
      Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Terrain", nameof (ShowTileHeightsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr);
      ShowTileHeightsSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr, nameof (_TerrainManager));
      ShowTileHeightsSystem.NativeFieldInfoPtr__DrawQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr, nameof (_DrawQuery));
      ShowTileHeightsSystem.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr, 100689258);
      ShowTileHeightsSystem.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr, 100689259);
      ShowTileHeightsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr, 100689260);
      ShowTileHeightsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr, 100689261);
    }

    public ShowTileHeightsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DrawQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystem.NativeFieldInfoPtr__DrawQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystem.NativeFieldInfoPtr__DrawQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GridIsActive
    {
      static GridIsActive()
      {
        Il2CppClassPointerStore<ShowTileHeightsSystem.GridIsActive>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr, nameof (GridIsActive));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileHeightsSystem.GridIsActive>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileHeightsSystem.GridIsActive>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ShowTileHeightsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DrawGridJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetTerrainHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBaseTerrainHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBaseGameplayHeights;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetBaseHeightLevels;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetCellBaseHeightLevels;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public DrawTileGridJob<ShowTileHeightsDebug> DrawGridJob;
      [FieldOffset(152)]
      public TerrainChunkLookup TerrainChunks;
      [FieldOffset(168)]
      public BufferFromEntity<ChunkTerrainHeights> GetTerrainHeights;
      [FieldOffset(208)]
      public BufferFromEntity<ChunkBaseTerrainHeights> GetBaseTerrainHeights;
      [FieldOffset(248)]
      public BufferFromEntity<ChunkBaseGameplayHeights> GetBaseGameplayHeights;
      [FieldOffset(288)]
      public BufferFromEntity<ChunkTileBaseHeightLevel> GetBaseHeightLevels;
      [FieldOffset(328)]
      public BufferFromEntity<ChunkCellBaseHeightLevel> GetCellBaseHeightLevels;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125113, XrefRangeEnd = 1125242, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ShowTileHeightsSystem.ShowTileHeightsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ShowTileHeightsJob()
      {
        Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileHeightsSystem>.NativeClassPtr, nameof (ShowTileHeightsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr);
        ShowTileHeightsSystem.ShowTileHeightsJob.NativeFieldInfoPtr_DrawGridJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, nameof (DrawGridJob));
        ShowTileHeightsSystem.ShowTileHeightsJob.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, nameof (TerrainChunks));
        ShowTileHeightsSystem.ShowTileHeightsJob.NativeFieldInfoPtr_GetTerrainHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, nameof (GetTerrainHeights));
        ShowTileHeightsSystem.ShowTileHeightsJob.NativeFieldInfoPtr_GetBaseTerrainHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, nameof (GetBaseTerrainHeights));
        ShowTileHeightsSystem.ShowTileHeightsJob.NativeFieldInfoPtr_GetBaseGameplayHeights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, nameof (GetBaseGameplayHeights));
        ShowTileHeightsSystem.ShowTileHeightsJob.NativeFieldInfoPtr_GetBaseHeightLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, nameof (GetBaseHeightLevels));
        ShowTileHeightsSystem.ShowTileHeightsJob.NativeFieldInfoPtr_GetCellBaseHeightLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, nameof (GetCellBaseHeightLevels));
        ShowTileHeightsSystem.ShowTileHeightsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, 100689262);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileHeightsSystem.ShowTileHeightsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
