// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.ShowSurfaceFluffSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Terrain
{
  public class ShowSurfaceFluffSystem : 
    DrawTileGridSystem<ShowSurfaceFluffDebug, ShowSurfaceFluffSystem.GridIsActive>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__DrawQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125065, XrefRangeEnd = 1125080, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowSurfaceFluffSystem.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125080, XrefRangeEnd = 1125107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowSurfaceFluffSystem.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125107, XrefRangeEnd = 1125110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowSurfaceFluffSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowSurfaceFluffSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125110, XrefRangeEnd = 1125113, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowSurfaceFluffSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowSurfaceFluffSystem()
    {
      Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Terrain", nameof (ShowSurfaceFluffSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr);
      ShowSurfaceFluffSystem.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr, nameof (_TerrainManager));
      ShowSurfaceFluffSystem.NativeFieldInfoPtr__DrawQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr, nameof (_DrawQuery));
      ShowSurfaceFluffSystem.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr, 100689252);
      ShowSurfaceFluffSystem.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr, 100689253);
      ShowSurfaceFluffSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr, 100689254);
      ShowSurfaceFluffSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr, 100689255);
    }

    public ShowSurfaceFluffSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowSurfaceFluffSystem.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowSurfaceFluffSystem.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DrawQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowSurfaceFluffSystem.NativeFieldInfoPtr__DrawQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowSurfaceFluffSystem.NativeFieldInfoPtr__DrawQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GridIsActive
    {
      static GridIsActive()
      {
        Il2CppClassPointerStore<ShowSurfaceFluffSystem.GridIsActive>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr, nameof (GridIsActive));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowSurfaceFluffSystem.GridIsActive>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowSurfaceFluffSystem.GridIsActive>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ShowSurfaceFluffJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DrawGridJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_TerrainChunks;
      private static readonly System.IntPtr NativeFieldInfoPtr_MouseTile;
      private static readonly System.IntPtr NativeFieldInfoPtr_GetSurfaceFluffAllowance;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public DrawTileGridJob<ShowSurfaceFluffDebug> DrawGridJob;
      [FieldOffset(152)]
      public TerrainChunkLookup TerrainChunks;
      [FieldOffset(168)]
      public int2 MouseTile;
      [FieldOffset(176)]
      public BufferFromEntity<SurfaceFluffAllowance> GetSurfaceFluffAllowance;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1125022, XrefRangeEnd = 1125065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ShowSurfaceFluffSystem.ShowSurfaceFluffJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ShowSurfaceFluffJob()
      {
        Il2CppClassPointerStore<ShowSurfaceFluffSystem.ShowSurfaceFluffJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowSurfaceFluffSystem>.NativeClassPtr, nameof (ShowSurfaceFluffJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowSurfaceFluffSystem.ShowSurfaceFluffJob>.NativeClassPtr);
        ShowSurfaceFluffSystem.ShowSurfaceFluffJob.NativeFieldInfoPtr_DrawGridJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSurfaceFluffSystem.ShowSurfaceFluffJob>.NativeClassPtr, nameof (DrawGridJob));
        ShowSurfaceFluffSystem.ShowSurfaceFluffJob.NativeFieldInfoPtr_TerrainChunks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSurfaceFluffSystem.ShowSurfaceFluffJob>.NativeClassPtr, nameof (TerrainChunks));
        ShowSurfaceFluffSystem.ShowSurfaceFluffJob.NativeFieldInfoPtr_MouseTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSurfaceFluffSystem.ShowSurfaceFluffJob>.NativeClassPtr, nameof (MouseTile));
        ShowSurfaceFluffSystem.ShowSurfaceFluffJob.NativeFieldInfoPtr_GetSurfaceFluffAllowance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowSurfaceFluffSystem.ShowSurfaceFluffJob>.NativeClassPtr, nameof (GetSurfaceFluffAllowance));
        ShowSurfaceFluffSystem.ShowSurfaceFluffJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowSurfaceFluffSystem.ShowSurfaceFluffJob>.NativeClassPtr, 100689256);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowSurfaceFluffSystem.ShowSurfaceFluffJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
