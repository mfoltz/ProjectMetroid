// Decompiled with JetBrains decompiler
// Type: ProjectM.ShowTileHeightsSystemNew
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Terrain;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ShowTileHeightsSystemNew : 
    DrawTileGridSystem<ShowTileHeightsDebugNew, ShowTileHeightsSystemNew.GridIsActive>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__TerrainManager;
    private static readonly System.IntPtr NativeFieldInfoPtr__TileWorldSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__DrawQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075028, XrefRangeEnd = 1075048, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileHeightsSystemNew.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075048, XrefRangeEnd = 1075128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdateDrawGridSystem()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileHeightsSystemNew.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075128, XrefRangeEnd = 1075131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShowTileHeightsSystemNew()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShowTileHeightsSystemNew.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1075131, XrefRangeEnd = 1075134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShowTileHeightsSystemNew.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShowTileHeightsSystemNew()
    {
      Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ShowTileHeightsSystemNew));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr);
      ShowTileHeightsSystemNew.NativeFieldInfoPtr__TerrainManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, nameof (_TerrainManager));
      ShowTileHeightsSystemNew.NativeFieldInfoPtr__TileWorldSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, nameof (_TileWorldSystem));
      ShowTileHeightsSystemNew.NativeFieldInfoPtr__DrawQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, nameof (_DrawQuery));
      ShowTileHeightsSystemNew.NativeMethodInfoPtr_OnCreateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, 100684699);
      ShowTileHeightsSystemNew.NativeMethodInfoPtr_OnUpdateDrawGridSystem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, 100684700);
      ShowTileHeightsSystemNew.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, 100684701);
      ShowTileHeightsSystemNew.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, 100684702);
    }

    public ShowTileHeightsSystemNew(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TerrainManager _TerrainManager
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystemNew.NativeFieldInfoPtr__TerrainManager));
        return pointer == System.IntPtr.Zero ? (TerrainManager) null : new TerrainManager(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystemNew.NativeFieldInfoPtr__TerrainManager), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TileWorldSystem _TileWorldSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystemNew.NativeFieldInfoPtr__TileWorldSystem));
        return pointer == System.IntPtr.Zero ? (TileWorldSystem) null : new TileWorldSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystemNew.NativeFieldInfoPtr__TileWorldSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe EntityQuery _DrawQuery
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystemNew.NativeFieldInfoPtr__DrawQuery));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShowTileHeightsSystemNew.NativeFieldInfoPtr__DrawQuery)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct GridIsActive
    {
      static GridIsActive()
      {
        Il2CppClassPointerStore<ShowTileHeightsSystemNew.GridIsActive>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, nameof (GridIsActive));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileHeightsSystemNew.GridIsActive>.NativeClassPtr);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileHeightsSystemNew.GridIsActive>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct HoveredTileData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_CellCoordinate;
      private static readonly System.IntPtr NativeFieldInfoPtr_Height;
      private static readonly System.IntPtr NativeFieldInfoPtr_AllocationState;
      private static readonly System.IntPtr NativeFieldInfoPtr_HeightLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileLayer;
      [FieldOffset(0)]
      public TileCellCoordinate CellCoordinate;
      [FieldOffset(8)]
      public float Height;
      [FieldOffset(12)]
      public ShowTileHeightsSystemNew.TileAllocationState AllocationState;
      [FieldOffset(16)]
      public byte HeightLevel;
      [FieldOffset(17)]
      public TileLayerIndex TileLayer;

      static HoveredTileData()
      {
        Il2CppClassPointerStore<ShowTileHeightsSystemNew.HoveredTileData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, nameof (HoveredTileData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileHeightsSystemNew.HoveredTileData>.NativeClassPtr);
        ShowTileHeightsSystemNew.HoveredTileData.NativeFieldInfoPtr_CellCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.HoveredTileData>.NativeClassPtr, nameof (CellCoordinate));
        ShowTileHeightsSystemNew.HoveredTileData.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.HoveredTileData>.NativeClassPtr, nameof (Height));
        ShowTileHeightsSystemNew.HoveredTileData.NativeFieldInfoPtr_AllocationState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.HoveredTileData>.NativeClassPtr, nameof (AllocationState));
        ShowTileHeightsSystemNew.HoveredTileData.NativeFieldInfoPtr_HeightLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.HoveredTileData>.NativeClassPtr, nameof (HeightLevel));
        ShowTileHeightsSystemNew.HoveredTileData.NativeFieldInfoPtr_TileLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.HoveredTileData>.NativeClassPtr, nameof (TileLayer));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileHeightsSystemNew.HoveredTileData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public enum TileAllocationState
    {
      Unknown,
      CellOutOfBounds,
      CellNotAllocated,
      LayerNotAllocated,
      Allocated,
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct ShowTileHeightsJob
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DrawGridJob;
      private static readonly System.IntPtr NativeFieldInfoPtr_MouseTile;
      private static readonly System.IntPtr NativeFieldInfoPtr_TileWorld;
      private static readonly System.IntPtr NativeFieldInfoPtr_HoveredTileData;
      private static readonly System.IntPtr NativeMethodInfoPtr_FillColor_Private_Void_BoundsMinMax_Int32_CellIntersection_NativeArray_1_Color32_Byte_TileAllocationState_TileLayerIndex_Color_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
      [FieldOffset(0)]
      public DrawTileGridJob<ShowTileHeightsDebugNew> DrawGridJob;
      [FieldOffset(152)]
      public int2 MouseTile;
      [FieldOffset(160)]
      public TileWorld TileWorld;
      [FieldOffset(184)]
      public NativeReference<ShowTileHeightsSystemNew.HoveredTileData> HoveredTileData;

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 1074935, RefRangeEnd = 1074939, XrefRangeStart = 1074930, XrefRangeEnd = 1074935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void FillColor(
        BoundsMinMax worldBounds,
        int drawSize,
        CellIntersection intersection,
        NativeArray<Color32> colors,
        byte heightLevel,
        ShowTileHeightsSystemNew.TileAllocationState allocationState,
        TileLayerIndex tileLayer,
        Color color)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[8];
        numPtr[0] = (System.IntPtr) &worldBounds;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &drawSize;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &intersection;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &colors;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &heightLevel;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &allocationState;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &tileLayer;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &color;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShowTileHeightsSystemNew.ShowTileHeightsJob.NativeMethodInfoPtr_FillColor_Private_Void_BoundsMinMax_Int32_CellIntersection_NativeArray_1_Color32_Byte_TileAllocationState_TileLayerIndex_Color_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074939, XrefRangeEnd = 1075028, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
        IL2CPP.il2cpp_runtime_invoke(ShowTileHeightsSystemNew.ShowTileHeightsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ShowTileHeightsJob()
      {
        Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowTileHeightsSystemNew>.NativeClassPtr, nameof (ShowTileHeightsJob));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr);
        ShowTileHeightsSystemNew.ShowTileHeightsJob.NativeFieldInfoPtr_DrawGridJob = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr, nameof (DrawGridJob));
        ShowTileHeightsSystemNew.ShowTileHeightsJob.NativeFieldInfoPtr_MouseTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr, nameof (MouseTile));
        ShowTileHeightsSystemNew.ShowTileHeightsJob.NativeFieldInfoPtr_TileWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr, nameof (TileWorld));
        ShowTileHeightsSystemNew.ShowTileHeightsJob.NativeFieldInfoPtr_HoveredTileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr, nameof (HoveredTileData));
        ShowTileHeightsSystemNew.ShowTileHeightsJob.NativeMethodInfoPtr_FillColor_Private_Void_BoundsMinMax_Int32_CellIntersection_NativeArray_1_Color32_Byte_TileAllocationState_TileLayerIndex_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr, 100684703);
        ShowTileHeightsSystemNew.ShowTileHeightsJob.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr, 100684704);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShowTileHeightsSystemNew.ShowTileHeightsJob>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
